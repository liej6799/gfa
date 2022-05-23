package com.example.gfamobile.ui.sale;

import static com.example.gfamobile.util.Intent.SALE_ITEM;

import android.content.Intent;
import android.os.Bundle;

import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Date;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.wdullaer.materialdatetimepicker.date.DatePickerDialog;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import dagger.android.support.DaggerFragment;

public class SaleFragment extends DaggerFragment implements DatePickerDialog.OnDateSetListener, SaleAdapter.SaleItemClickListener {

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    private SaleAdapter saleAdapter;
    private SaleViewModel saleViewModel;

    @BindView(R.id.rv_item_sale)
    RecyclerView rv_item_sale;

    @BindView(R.id.et_sale_start_date)
    EditText et_sale_start_date;

    @BindView(R.id.et_sale_end_date)
    EditText et_sale_end_date;


    @BindView(R.id.srl_item_sale)
    SwipeRefreshLayout srl_item_sale;



    private Date date = new Date();
    private boolean isStartDateSelected = false;
    private boolean isEndDateSelected = false;

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
        rv_item_sale.addItemDecoration(dividerItemDecoration);

        et_sale_start_date.setText(String.format("%d/%d/%d", date.getStartDayOfMonth(), date.getStartMonth(), date.getStartYear()));
        et_sale_end_date.setText(String.format("%d/%d/%d", date.getEndDayOfMonth(), date.getEndMonth(), date.getEndYear()));

        saleViewModel.getSales(date);
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

        et_sale_start_date.setOnClickListener(v -> {
            DatePickerDialog dpd = DatePickerDialog.newInstance(
                    SaleFragment.this,
                    date.getStartYear(), // Initial year selection
                    date.getStartMonth(), // Initial month selection
                    date.getStartDayOfMonth() // Inital day selection
            );

            dpd.show(getFragmentManager(), "Datepickerdialog");
            dpd.setAccentColor(getResources().getColor(R.color.mdtp_accent_color_dark));
            isStartDateSelected = true;
        });

        et_sale_end_date.setOnClickListener(v -> {
            DatePickerDialog dpd = DatePickerDialog.newInstance(
                    SaleFragment.this,
                    date.getEndYear(), // Initial year selection
                    date.getEndMonth(), // Initial month selection
                    date.getEndDayOfMonth() // Inital day selection
            );

            dpd.show(getFragmentManager(), "Datepickerdialog");
            dpd.setAccentColor(getResources().getColor(R.color.mdtp_accent_color_dark));
            isEndDateSelected = true;
        });

        srl_item_sale.setOnRefreshListener(() -> {
            saleViewModel.getSales(date);
        });
    }

    @Override
    public void onDateSet(DatePickerDialog view, int year, int monthOfYear, int dayOfMonth) {
        if (isStartDateSelected)
        {
            isStartDateSelected = false;
            date.setStartDayOfMonth(dayOfMonth);
            date.setStartMonth(monthOfYear);
            date.setStartYear(year);
            et_sale_start_date.setText(String.format("%d/%d/%d", date.getStartDayOfMonth(), date.getStartMonth(), date.getStartYear()));
            saleViewModel.getSales(date);
        }
        else if (isEndDateSelected)
        {
            isEndDateSelected = false;
            date.setEndDayOfMonth(dayOfMonth);
            date.setEndMonth(monthOfYear);
            date.setEndYear(year);
            et_sale_end_date.setText(String.format("%d/%d/%d", date.getEndDayOfMonth(), date.getEndMonth(), date.getEndYear()));
            saleViewModel.getSales(date);
        }
    }

    @Override
    public void onItemClick(View view, int position) {
        Intent intent = new Intent(getActivity(), SaleItemActivity.class);
        intent.putExtra(SALE_ITEM, saleAdapter.getId(position).toString());
        startActivity(intent);
    }
}