package com.example.gfamobile.ui.sale;

import static com.example.gfamobile.util.Resource.AuthStatus.AUTHENTICATED;

import android.content.Intent;
import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Sale;
import com.example.gfamobile.data.model.SaleItem;
import com.example.gfamobile.ui.item.ItemViewModel;
import com.example.gfamobile.util.ViewModelProviderFactory;

import java.util.ArrayList;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import dagger.android.support.DaggerFragment;

public class SaleFragment extends DaggerFragment {

    private SaleAdapter saleAdapter;
    private SaleViewModel saleViewModel;
    private RecyclerView recyclerView;

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;


    public SaleFragment() {
        // require a empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        View view = inflater.inflate(R.layout.fragment_sale, container, false);
        saleViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(SaleViewModel.class);
        saleViewModel.getSales();



        recyclerView = (RecyclerView) view.findViewById(R.id.rv_item_sale);
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());

        recyclerView.setLayoutManager(linearLayoutManager);


        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(recyclerView.getContext(),
                linearLayoutManager.getOrientation());
        recyclerView.addItemDecoration(dividerItemDecoration);
        listener();
        return view;
    }

    private void listener()
    {
        saleViewModel.observeSale().observe(getViewLifecycleOwner(), saleList -> {
            if (saleList != null) {
                saleAdapter = new SaleAdapter(getContext(), saleList);
                recyclerView.setAdapter(saleAdapter);
            }
        });
    }
}