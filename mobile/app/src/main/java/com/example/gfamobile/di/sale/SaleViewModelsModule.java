package com.example.gfamobile.di.sale;

import androidx.lifecycle.ViewModel;

import com.example.gfamobile.di.ViewModelKey;
import com.example.gfamobile.ui.sale.SaleViewModel;

import dagger.Binds;
import dagger.Module;
import dagger.multibindings.IntoMap;

@Module
public abstract class SaleViewModelsModule {

    @Binds
    @IntoMap
    @ViewModelKey(SaleViewModel.class)
    public abstract ViewModel bindSaleVieModel(SaleViewModel saleViewModel);

}
