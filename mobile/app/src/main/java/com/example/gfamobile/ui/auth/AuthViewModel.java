package com.example.gfamobile.ui.auth;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

import com.example.gfamobile.SessionManager;
import com.example.gfamobile.data.model.User;
import com.example.gfamobile.di.sharedpref.CustomSharedPreferences;
import com.example.gfamobile.util.Resource;

import net.openid.appauth.AuthState;

import javax.inject.Inject;

public class AuthViewModel extends ViewModel {
    private CustomSharedPreferences customSharedPreferences;
    private SessionManager sessionManager;

    @Inject
    public AuthViewModel(CustomSharedPreferences _customSharedPreferences, SessionManager _sessionManager) {
        customSharedPreferences = _customSharedPreferences;
        sessionManager = _sessionManager;

    }


    public void login(AuthState authState)
    {
        User user = new User();
        MutableLiveData<Resource<User>> userResource = new MutableLiveData<>();

        user.setAccessToken(authState.getAccessToken());
        user.setRefreshToken(authState.getRefreshToken());
        userResource.setValue(Resource.authenticated(user));
        sessionManager.authenticateUser(userResource);
    }

    public void initial()
    {
        MutableLiveData<Resource<User>> userResource = new MutableLiveData<>();
        userResource.setValue(Resource.logout());
        sessionManager.authenticateUser(userResource);
    }

    public void AuthHandler(AuthState authState)
    {
        Boolean successAuthenticate = false;
        if (authState != null)
        {
            if (authState.isAuthorized())
            {
                if (authState.getAccessToken() != null && authState.getRefreshToken() != null)
                {

                    successAuthenticate = true;
                }
            }

        }

        if (successAuthenticate)
        {
            login(authState);
        }
        else {
            initial();
        }
    }

    public LiveData<Resource<User>> observeAuthState() {
        return sessionManager.getAuthUser();
    }

}
