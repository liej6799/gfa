package com.example.gfamobile.di;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.di.auth.AuthViewModelsModule;
import com.example.gfamobile.di.item.ItemViewModelsModule;
import com.example.gfamobile.ui.auth.LoginActivity;
import com.example.gfamobile.ui.item.ItemFragment;
import com.example.gfamobile.ui.item.ItemViewModel;

import dagger.Module;
import dagger.android.ContributesAndroidInjector;

@Module
public abstract class ActivityBuilderModule {
    @ContributesAndroidInjector(
            modules = {ItemViewModelsModule.class}
    )
    abstract MainActivity contributeMainActivity();

    @ContributesAndroidInjector(
            modules = {AuthViewModelsModule.class}
    )
    abstract LoginActivity contributeLoginActivity();

    @ContributesAndroidInjector(
            modules = {ItemViewModelsModule.class}
    )
    abstract ItemFragment contributeItemFragment();
}