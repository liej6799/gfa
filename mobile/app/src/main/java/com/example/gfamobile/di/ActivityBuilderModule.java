package com.example.gfamobile.di;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.di.auth.AuthViewModelsModule;
import com.example.gfamobile.di.home.HomeViewModelsModule;
import com.example.gfamobile.di.item.ItemViewModelsModule;
import com.example.gfamobile.di.sale.SaleViewModelsModule;
import com.example.gfamobile.di.saleitem.SaleItemViewModelsModule;
import com.example.gfamobile.ui.auth.LoginActivity;
import com.example.gfamobile.ui.home.HomeFragment;
import com.example.gfamobile.ui.item.ItemFragment;
import com.example.gfamobile.ui.item.ItemViewModel;
import com.example.gfamobile.ui.sale.SaleFragment;
import com.example.gfamobile.ui.sale.SaleItemActivity;
import com.example.gfamobile.ui.sale.SaleViewModel;

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

    @ContributesAndroidInjector(
            modules = {SaleViewModelsModule.class}
    )
    abstract HomeFragment contributeHomeFragment();


    @ContributesAndroidInjector(
            modules = {SaleViewModelsModule.class}
    )
    abstract SaleFragment contributeSaleFragment();

    @ContributesAndroidInjector(
            modules = {SaleItemViewModelsModule.class, SaleViewModelsModule.class}
    )
    abstract SaleItemActivity contributeSaleItemActivity();


}