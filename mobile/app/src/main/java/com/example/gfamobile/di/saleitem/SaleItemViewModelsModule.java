package com.example.gfamobile.di.saleitem;

import androidx.lifecycle.ViewModel;

import com.example.gfamobile.di.ViewModelKey;
import com.example.gfamobile.ui.sale.SaleItemViewModel;

import dagger.Binds;
import dagger.Module;
import dagger.multibindings.IntoMap;

@Module
public abstract class SaleItemViewModelsModule {

    @Binds
    @IntoMap
    @ViewModelKey(SaleItemViewModel.class)
    public abstract ViewModel bindSaleItemVieModel(SaleItemViewModel saleItemViewModel);

}
