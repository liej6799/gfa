package com.example.gfamobile.di;

import android.app.Application;

import com.example.gfamobile.BaseApplication;
import com.example.gfamobile.SessionManager;
import com.example.gfamobile.di.sharedpref.SharedPreferencesModule;

import javax.inject.Singleton;

import dagger.BindsInstance;
import dagger.Component;
import dagger.android.AndroidInjector;
import dagger.android.support.AndroidSupportInjectionModule;

@Singleton
@Component(
        modules = {
                AndroidSupportInjectionModule.class,
                ActivityBuilderModule.class,
                AppModule.class,
                ViewModelFactoryModule.class,
                SharedPreferencesModule.class,
        }
)

public interface AppComponent extends AndroidInjector<BaseApplication> {

    SessionManager sessionManager();

    @Component.Builder
    interface Builder {

        @BindsInstance
        Builder application(Application application);


        AppComponent build();
    }
}