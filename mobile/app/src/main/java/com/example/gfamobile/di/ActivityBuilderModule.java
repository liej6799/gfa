package com.example.gfamobile.di;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.di.auth.AuthViewModelsModule;
import com.example.gfamobile.ui.auth.LoginActivity;

import dagger.Module;
import dagger.android.ContributesAndroidInjector;

@Module
public abstract class ActivityBuilderModule {
    @ContributesAndroidInjector(
            modules = {}
    )
    abstract MainActivity contributeMainActivity();

    @ContributesAndroidInjector(
            modules = {AuthViewModelsModule.class}
    )
    abstract LoginActivity contributeLoginActivity();
}