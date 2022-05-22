package com.example.gfamobile.di.home;

import androidx.lifecycle.ViewModel;

import com.example.gfamobile.di.ViewModelKey;
import com.example.gfamobile.ui.home.HomeViewModel;

import dagger.Binds;
import dagger.Module;
import dagger.multibindings.IntoMap;

@Module
public abstract class HomeViewModelsModule {

    @Binds
    @IntoMap
    @ViewModelKey(HomeViewModel.class)
    public abstract ViewModel bindHomeVieModel(HomeViewModel homeViewModel
    );

}
