package com.example.gfamobile.ui.sale;

import android.content.ClipData;
import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;

import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Sale;
import com.example.gfamobile.data.model.SaleItem;

import java.util.List;

public class SaleItemAdapter extends RecyclerView.Adapter<SaleItemAdapter.ViewHolder> {

    private final List<SaleItem> mData;
    private final LayoutInflater mInflater;

    // data is passed into the constructor
    SaleItemAdapter(Context context, List<SaleItem> data) {
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

        SaleItem saleitem = mData.get(position);
        holder.quantity.setText(saleitem.getQuantity());
        holder.name.setText(saleitem.getName());
        holder.price.setText(String.valueOf(saleitem.getPrice()));
        holder.total.setText(String.valueOf(saleitem.getTotal()));
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
