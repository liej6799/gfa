package com.example.gfamobile.ui.sale;

import static com.example.gfamobile.util.Intent.SALE_ITEM;
import static com.example.gfamobile.util.Intent.SALE_ITEM_ID;
import static com.example.gfamobile.util.Intent.SALE_SUMMARY;
import static com.example.gfamobile.util.Intent.SALE_SUMMARY_END_DATE;
import static com.example.gfamobile.util.Intent.SALE_SUMMARY_START_DATE;

import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.example.gfamobile.R;
import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.util.Helper;
import com.example.gfamobile.util.ViewModelProviderFactory;

import org.joda.time.DateTime;

import java.util.List;
import java.util.UUID;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import io.swagger.client.model.GfaWebSalesSaleItemDto;

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

    @BindView(R.id.tv_sale_item_sayur)
    TextView tv_sale_item_sayur;

    @BindView(R.id.tv_sale_item_total_end)
    TextView tv_sale_item_total_end;

    @BindView(R.id.tv_sale_item_date_time)
    TextView tv_sale_item_date_time;


    @BindView(R.id.ll_sale_item_cash)
    LinearLayout ll_sale_item_cash;

    @BindView(R.id.ll_sale_item_change)
    LinearLayout ll_sale_item_change;


    @BindView(R.id.ll_sale_item_sayur)
    LinearLayout ll_sale_item_sayur;




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

        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
        rv_item_sale_item.setLayoutManager(linearLayoutManager);

        if (intent.getBooleanExtra(SALE_ITEM, false))
        {
            String message = intent.getStringExtra(SALE_ITEM_ID).toString();

            ll_sale_item_cash.setVisibility(View.VISIBLE);
            ll_sale_item_change.setVisibility(View.VISIBLE);
            ll_sale_item_sayur.setVisibility(View.GONE);
            saleItemViewModel.getSaleItem(UUID.fromString(message));
            saleViewModel.getSalesId(UUID.fromString(message));
            saleItemListener();
        }
        else if (intent.getBooleanExtra(SALE_SUMMARY, false))
        {
            ll_sale_item_cash.setVisibility(View.GONE);
            ll_sale_item_change.setVisibility(View.GONE);
            ll_sale_item_sayur.setVisibility(View.VISIBLE);

            saleItemViewModel.getSaleItemDateSummary(DateTime.parse(intent.getStringExtra(SALE_SUMMARY_START_DATE)),
                    DateTime.parse(intent.getStringExtra(SALE_SUMMARY_END_DATE)));

            saleSummaryListener(DateTime.parse(intent.getStringExtra(SALE_SUMMARY_START_DATE)));

        }
    }
    private void saleSummaryListener(DateTime dateTime)
    {
        saleItemViewModel.observeSaleItem().observe(this, saleList -> {
            if (saleList != null) {
                if(saleList.size() >0) {
                    saleItemAdapter = new SaleItemAdapter(this, saleList);
                    rv_item_sale_item.setAdapter(saleItemAdapter);

                    tv_sale_item_date_time.setText(dateTime.toString("EEE, dd MMM YYYY"));
                    tv_sale_item_total.setText(Helper.GetCurrencyHelper().format(getTotal(saleList)));
                    tv_sale_item_total_end.setText(Helper.GetCurrencyHelper().format(getTotal(saleList)));
                    tv_sale_item_sayur.setText(Helper.GetCurrencyHelper().format(getSayurTotal(saleList)));
                }
            }
        });
    }
    private Double getTotal(List<GfaWebSalesSaleItemDto> input)
    {
        Double total = 0.0;
        for (int i = 0; i < input.size(); i++)
        {
            total += input.get(i).getTotal();
        }

        return total;
    }
    private Double getSayurTotal(List<GfaWebSalesSaleItemDto> input)
    {
        for (int i = 0; i < input.size(); i++)
        {
            if(input.get(i).getItemName().equals("SAYUR"))
            {
                return input.get(i).getTotal();
            }
        }

        return 0.0;
    }
    private void saleItemListener()
    {
        saleItemViewModel.observeSaleItem().observe(this, saleList -> {
            if (saleList != null) {
                saleItemAdapter = new SaleItemAdapter(this, saleList);
                rv_item_sale_item.setAdapter(saleItemAdapter);
            }
        });

        saleViewModel.observeSaleId().observe(this, saleId -> {
            if (saleId != null) {
                tv_sale_item_total.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleId.getTotalCash())));
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