package com.example.gfamobile.ui.item;

import static com.example.gfamobile.util.Intent.ITEM_DETAIL_ID;
import static com.example.gfamobile.util.Intent.SALE_ITEM_ID;

import androidx.appcompat.app.AppCompatActivity;
import androidx.lifecycle.ViewModelProvider;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

import com.example.gfamobile.R;
import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.ui.sale.SaleItemViewModel;
import com.example.gfamobile.ui.sale.SaleViewModel;
import com.example.gfamobile.util.Helper;
import com.example.gfamobile.util.ViewModelProviderFactory;

import java.util.UUID;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;

public class ItemDetailsActivity extends PortraitDaggerAppCompatActivity {


    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    @BindView(R.id.tv_item_details_summary_name)
    TextView tv_item_details_summary_name;

    @BindView(R.id.tv_item_details_summary_code)
    TextView tv_item_details_summary_code;

    @BindView(R.id.tv_item_details_summary_quantity)
    TextView tv_item_details_summary_quantity;

    @BindView(R.id.tv_item_details_summary_buy_price)
    TextView tv_item_details_summary_buy_price;

    @BindView(R.id.tv_item_details_summary_sell_price)
    TextView tv_item_details_summary_sell_price;

    @BindView(R.id.tv_item_details_summary_profitloss)
    TextView tv_item_details_summary_profitloss;

    private ItemViewModel itemViewModel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_item_details);
        ButterKnife.bind(this);

        itemViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(ItemViewModel.class);

        getSupportActionBar().setTitle("Item Details");
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        Intent intent = getIntent();
        String message = intent.getStringExtra(ITEM_DETAIL_ID).toString();
        itemViewModel.getItem(UUID.fromString(message));
        listener();
    }
    private void listener()
    {
        itemViewModel.observeItem().observe(this, itemDetails -> {
            if (itemDetails != null) {

                tv_item_details_summary_name.setText(itemDetails.getName());
                tv_item_details_summary_code.setText(itemDetails.getCode());
                tv_item_details_summary_quantity.setText(String.valueOf(itemDetails.getQuantity()));
                tv_item_details_summary_buy_price.setText(Helper.GetCurrencyHelper().format(itemDetails.getBuyPrice()));
                tv_item_details_summary_sell_price.setText(Helper.GetCurrencyHelper().format(itemDetails.getSellPrice()));
                tv_item_details_summary_profitloss.setText(Helper.GetCurrencyHelper().format(itemDetails.getProfitLoss()));
            }
        });
    }

    @Override
    public boolean onSupportNavigateUp() {
        finish();
        return true;
    }
}