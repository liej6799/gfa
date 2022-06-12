package com.example.gfamobile.ui.sale;

import static com.example.gfamobile.util.Intent.SALE_ITEM;
import static com.example.gfamobile.util.Intent.SALE_ITEM_ID;

import android.content.Intent;
import android.os.Bundle;

import androidx.core.util.Pair;
import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.TextView;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Date;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.google.android.material.datepicker.MaterialDatePicker;
import com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener;
import com.wdullaer.materialdatetimepicker.date.DatePickerDialog;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import dagger.android.support.DaggerFragment;

public class SaleFragment extends DaggerFragment implements SaleAdapter.SaleItemClickListener {

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    private SaleAdapter saleAdapter;
    private SaleViewModel saleViewModel;

    @BindView(R.id.rv_item_sale)
    RecyclerView rv_item_sale;

    @BindView(R.id.srl_item_sale)
    SwipeRefreshLayout srl_item_sale;

    public SaleFragment() {
        // require a empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        View view = inflater.inflate(R.layout.fragment_sale, container, false);
        ButterKnife.bind(this, view);

        saleViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(SaleViewModel.class);

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());
        rv_item_sale.setLayoutManager(linearLayoutManager);
        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(rv_item_sale.getContext(),
                linearLayoutManager.getOrientation());
        saleViewModel.getSales(MainActivity.getDate());
        listener();
        return view;
    }

    private void listener()
    {
        saleViewModel.observeSaleList().observe(getViewLifecycleOwner(), saleList -> {
            if (saleList != null) {
                saleAdapter = new SaleAdapter(getContext(), saleList);
                rv_item_sale.setAdapter(saleAdapter);
                saleAdapter.setClickListener(this);

                srl_item_sale.setRefreshing(false);
            }
        });

        srl_item_sale.setOnRefreshListener(() -> saleViewModel.getSales(MainActivity.getDate()));

    }


    @Override
    public void onItemClick(View view, int position) {
        Intent intent = new Intent(getActivity(), SaleItemActivity.class);
        intent.putExtra(SALE_ITEM,true);
        intent.putExtra(SALE_ITEM_ID, saleAdapter.getId(position).toString());
        startActivity(intent);
    }

    public void setDate(Date date) {
        saleViewModel.getSales(date);
    }
}