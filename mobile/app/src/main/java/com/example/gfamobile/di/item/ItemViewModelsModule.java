package com.example.gfamobile.di.item;

import androidx.lifecycle.ViewModel;

import com.example.gfamobile.di.ViewModelKey;
import com.example.gfamobile.ui.item.ItemViewModel;

import dagger.Binds;
import dagger.Module;
import dagger.multibindings.IntoMap;

@Module
public abstract class ItemViewModelsModule {

    @Binds
    @IntoMap
    @ViewModelKey(ItemViewModel.class)
    public abstract ViewModel bindItemVieModel(ItemViewModel itemViewModel);

}
