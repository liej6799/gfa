package com.example.gfamobile.ui.sale;

import android.content.Context;
import android.view.LayoutInflater;

import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.gfamobile.R;
import com.example.gfamobile.util.Helper;

import java.text.NumberFormat;
import java.util.Currency;
import java.util.List;

import io.swagger.client.model.GfaWebSalesSaleItemDto;

public class SaleItemAdapter extends RecyclerView.Adapter<SaleItemAdapter.ViewHolder> {

    private final List<GfaWebSalesSaleItemDto> mData;
    private final LayoutInflater mInflater;

    // data is passed into the constructor
    SaleItemAdapter(Context context, List<GfaWebSalesSaleItemDto> data) {
        this.mInflater = LayoutInflater.from(context);
        this.mData = data;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = mInflater.inflate(R.layout.item_sale_item, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {



        GfaWebSalesSaleItemDto saleitem = mData.get(position);
        holder.quantity.setText(String.valueOf(saleitem.getQuantity()));
        holder.name.setText(saleitem.getItemName());
        holder.price.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleitem.getPrice())));
        holder.total.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleitem.getTotal())));
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView quantity;
        TextView name;
        TextView total;
        TextView price;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            quantity = itemView.findViewById(R.id.tv_item_sale_item_quantity);
            name = itemView.findViewById(R.id.tv_item_sale_item_name);
            price = itemView.findViewById(R.id.tv_item_sale_item_price);
            total = itemView.findViewById(R.id.tv_item_sale_item_total);
        }
    }
}
