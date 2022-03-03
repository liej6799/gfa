package com.example.gfamobile.di;

import android.text.TextUtils;

import com.example.gfamobile.di.sharedpref.CustomSharedPreferences;
import com.example.gfamobile.util.Constant;

import net.openid.appauth.AuthState;

import org.json.JSONException;

import javax.inject.Singleton;

import dagger.Module;
import dagger.Provides;
import io.swagger.client.ApiClient;


@Module
public class AppModule {

    @Singleton
    @Provides
    static ApiClient provideApiClient(CustomSharedPreferences customSharedPreferences)
    {
        AuthState authState = new AuthState();
        ApiClient apiClient = new ApiClient();
        apiClient.setBasePath(Constant.DEV_BASE_URL);

        String jsonString = customSharedPreferences.getAppAuth();
        if (!TextUtils.isEmpty(jsonString)) {
            try {
                assert jsonString != null;
                authState = AuthState.jsonDeserialize(jsonString);
            } catch (JSONException jsonException) {
                // should never happen
            }
            String token = authState.getAccessToken();
            apiClient.addDefaultHeader("Authorization", "Bearer " + token);

            return apiClient;
        }
        else {
            return apiClient;
        }
    }


}
