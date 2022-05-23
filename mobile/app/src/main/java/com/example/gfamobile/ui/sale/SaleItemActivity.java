package com.example.gfamobile.ui.sale;

import static com.example.gfamobile.util.Intent.SALE_ITEM;

import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

import com.example.gfamobile.R;
import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.util.Helper;
import com.example.gfamobile.util.ViewModelProviderFactory;

import java.util.UUID;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;

public class SaleItemActivity extends PortraitDaggerAppCompatActivity {

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;


    @BindView(R.id.rv_item_sale_item)
    RecyclerView rv_item_sale_item;

    @BindView(R.id.tv_sale_item_total)
    TextView tv_sale_item_total;

    @BindView(R.id.tv_sale_item_cash)
    TextView tv_sale_item_cash;

    @BindView(R.id.tv_sale_item_change)
    TextView tv_sale_item_change;

    @BindView(R.id.tv_sale_item_total_end)
    TextView tv_sale_item_total_end;

    @BindView(R.id.tv_sale_item_date_time)
    TextView tv_sale_item_date_time;



    private SaleItemAdapter saleItemAdapter;

    private SaleItemViewModel saleItemViewModel;
    private SaleViewModel saleViewModel;
    @Override
    protected void onCreate(Bundle savedInstanceState) {


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sale_item);
        ButterKnife.bind(this);

        saleItemViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(SaleItemViewModel.class);
        saleViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(SaleViewModel.class);


        getSupportActionBar().setTitle("Sale item");
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        Intent intent = getIntent();
        String message = intent.getStringExtra(SALE_ITEM).toString();

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
        rv_item_sale_item.setLayoutManager(linearLayoutManager);

        saleItemViewModel.getSaleItem(UUID.fromString(message));
        saleViewModel.getSalesId(UUID.fromString(message));
        listener();
    }

    private void listener()
    {
        saleItemViewModel.observeSaleItem().observe(this, saleList -> {
            if (saleList != null) {
                saleItemAdapter = new SaleItemAdapter(this, saleList);
                rv_item_sale_item.setAdapter(saleItemAdapter);
            }
        });

        saleViewModel.observeSaleId().observe(this, saleId -> {
            if (saleId != null) {
                tv_sale_item_total.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleId.getTotalAmount())));
                tv_sale_item_cash.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleId.getTotalCash())));
                tv_sale_item_change.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleId.getTotalChange())));
                tv_sale_item_total_end.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleId.getTotalAmount())));
                tv_sale_item_date_time.setText(saleId.getDateSales().toString("EEE, dd MMM, yyyy hh:mm a"));
            }
        });
    }

    @Override
    public boolean onSupportNavigateUp() {
        finish();
        return true;
    }
}