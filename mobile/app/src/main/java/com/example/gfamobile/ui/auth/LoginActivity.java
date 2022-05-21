package com.example.gfamobile.ui.auth;

import static com.example.gfamobile.util.Constant.OIDC_CLIENT_ID;
import static com.example.gfamobile.util.Constant.OIDC_REDIRECT_URI;
import static com.example.gfamobile.util.Constant.OIDC_ISSUER;
import static com.example.gfamobile.util.Constant.OIDC_SCOPE;
import static com.example.gfamobile.util.Resource.AuthStatus.AUTHENTICATED;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.lifecycle.ViewModelProvider;

import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Log;
import android.widget.Button;


import com.example.gfamobile.MainActivity;
import com.example.gfamobile.R;
import com.example.gfamobile.di.sharedpref.CustomSharedPreferences;
import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.util.ViewModelProviderFactory;

import net.openid.appauth.AuthState;
import net.openid.appauth.AuthorizationException;
import net.openid.appauth.AuthorizationRequest;
import net.openid.appauth.AuthorizationResponse;
import net.openid.appauth.AuthorizationService;
import net.openid.appauth.AuthorizationServiceConfiguration;
import net.openid.appauth.AuthorizationServiceDiscovery;
import net.openid.appauth.TokenRequest;
import net.openid.appauth.TokenResponse;

import org.json.JSONException;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;

public class LoginActivity extends PortraitDaggerAppCompatActivity {


    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    @Inject
    CustomSharedPreferences customSharedPreferences;

    private AuthViewModel authViewModel;
    private AuthorizationService mAuthService;
    private AuthState mAuthState;

    @BindView(R.id.btn_login)
    Button btn_continue_login;

    // Log
    private static final String TAG = "LoginActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        ButterKnife.bind(this);

        authViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(AuthViewModel.class);
        btn_continue_login.setOnClickListener(x -> login());

        mAuthService = new AuthorizationService(this);
        listener();
        enablePostAuthorizationFlows();
    }

    private void listener()
    {
        authViewModel.observeAuthState().observe(this, userResource -> {
            if (userResource != null) {
                if (userResource.status == AUTHENTICATED)
                {
                    Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                    startActivity(intent);
                }
            }

        });

    }
    private void performTokenRequest(TokenRequest tokenRequest) {

        mAuthService.performTokenRequest(
                tokenRequest,
                this::receivedTokenResponse
        );
    }

    private void receivedTokenResponse(
            @Nullable TokenResponse tokenResponse,
            @Nullable AuthorizationException authException) {
        Log.d(TAG, "Token request complete");
        if (tokenResponse != null && authException == null)
        {
            mAuthState.update(tokenResponse, authException);
            persistAuthState(mAuthState);
        }
    }

    public void login()
    {
        final AuthorizationServiceConfiguration.RetrieveConfigurationCallback retrieveCallback =
                (serviceConfiguration, ex) -> {
                    if (ex != null) {
                        Log.w(TAG, "Failed to retrieve configuration for " + OIDC_ISSUER, ex);
                    } else {
                        Log.d(TAG, "configuration retrieved for " + OIDC_ISSUER
                                + ", proceeding");
                        authorize(serviceConfiguration);
                    }
                };

        String discoveryEndpoint = OIDC_ISSUER + "/.well-known/openid-configuration";

        AuthorizationServiceConfiguration.fetchFromUrl(Uri.parse(discoveryEndpoint), retrieveCallback);
    }

    private void authorize(AuthorizationServiceConfiguration authServiceConfiguration)
    {
        AuthorizationRequest authRequest = new AuthorizationRequest.Builder(
                authServiceConfiguration,
                OIDC_CLIENT_ID,
                "code",
                Uri.parse(OIDC_REDIRECT_URI))
                .setScope(OIDC_SCOPE)
                .build();




        mAuthService.performAuthorizationRequest(
                authRequest,
                createPostAuthorizationIntent(
                        this,
                        authRequest,
                        authServiceConfiguration.discoveryDoc));
    }

    private PendingIntent createPostAuthorizationIntent(
            @NonNull Context context,
            @NonNull AuthorizationRequest request,
            @Nullable AuthorizationServiceDiscovery discoveryDoc) {

        Intent intent = new Intent(context, this.getClass());

        return PendingIntent.getActivity(context, request.hashCode(), intent, PendingIntent.FLAG_MUTABLE);
        

    }

    private void persistAuthState(@NonNull AuthState authState) {
        customSharedPreferences.putAppAuth(authState.jsonSerializeString());

        enablePostAuthorizationFlows();
    }


    private void enablePostAuthorizationFlows()
    {
        Intent intent = getIntent();
        if (intent != null) {
            mAuthState = restoreAuthState();
            if (mAuthState == null)
            {
                AuthorizationResponse response = AuthorizationResponse.fromIntent(getIntent());
                AuthorizationException ex = AuthorizationException.fromIntent(getIntent());

                if (response != null || ex != null) {
                    mAuthState = new AuthState(response, ex);
                }

                if (response != null) {
                    Log.d(TAG, "Received AuthorizationResponse.");
                    performTokenRequest(response.createTokenExchangeRequest());
                } else {
                    Log.i(TAG, "Authorization failed: " + ex);
                }
            }
            else {
                authViewModel.AuthHandler(mAuthState);
            }
        }
    }
    @Nullable
    private AuthState restoreAuthState() {

        String jsonString = customSharedPreferences.getAppAuth();
        if (!TextUtils.isEmpty(jsonString)) {
            try {
                assert jsonString != null;
                return AuthState.jsonDeserialize(jsonString);
            } catch (JSONException jsonException) {
                // should never happen
            }
        }
        return null;
    }
}