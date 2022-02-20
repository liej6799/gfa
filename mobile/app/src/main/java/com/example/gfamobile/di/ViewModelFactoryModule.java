package com.example.gfamobile.di;

import androidx.lifecycle.ViewModelProvider;

import com.example.gfamobile.util.ViewModelProviderFactory;

import dagger.Binds;
import dagger.Module;
import dagger.Provides;

@Module
public abstract class ViewModelFactoryModule {

    @Binds
    public abstract ViewModelProvider.Factory bindViewModelFactory(ViewModelProviderFactory viewModelProviderFactory);

    @Provides
    static ViewModelProvider.Factory bindFactory(ViewModelProviderFactory factory) {
        return factory;
    }


}
