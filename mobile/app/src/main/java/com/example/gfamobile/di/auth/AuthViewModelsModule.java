package com.example.gfamobile.di.auth;

import androidx.lifecycle.ViewModel;

import com.example.gfamobile.di.ViewModelKey;
import com.example.gfamobile.ui.auth.AuthViewModel;

import dagger.Binds;
import dagger.Module;
import dagger.multibindings.IntoMap;

@Module
public abstract class AuthViewModelsModule {

    @Binds
    @IntoMap
    @ViewModelKey(AuthViewModel.class)
    public abstract ViewModel bindAuthViewModel(AuthViewModel authViewModel);

}
