package com.example.gfamobile.ui.item;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.R;
import com.example.gfamobile.util.ViewModelProviderFactory;

import javax.inject.Inject;

import dagger.android.support.DaggerFragment;

public class ItemFragment extends DaggerFragment {

    private ItemViewModel itemViewModel;

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        itemViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(ItemViewModel.class);
        itemViewModel.getItemCount();

        return inflater.inflate(R.layout.fragment_item, container, false);
    }
}