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
import java.util.UUID;

import io.swagger.client.model.GfaWebSalesSaleDto;

public class SaleAdapter extends RecyclerView.Adapter<SaleAdapter.ViewHolder> {

    private final List<GfaWebSalesSaleDto> mData;
    private final LayoutInflater mInflater;
    private SaleItemClickListener mClickListener;

    // data is passed into the constructor
    SaleAdapter(Context context, List<GfaWebSalesSaleDto> data) {
        this.mInflater = LayoutInflater.from(context);
        this.mData = data;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = mInflater.inflate(R.layout.item_sale, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        GfaWebSalesSaleDto sale = mData.get(position);
        holder.time.setText(sale.getDateSales().toString("hh:mm a"));
        holder.date.setText(sale.getDateSales().toString("EEE, dd MMM, yyyy"));

        holder.total.setText(String.valueOf(Helper.GetCurrencyHelper().format(sale.getTotalAmount())));
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener {
        TextView total;
        TextView time;
        TextView date;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            total = itemView.findViewById(R.id.tv_item_sale_total);
            time = itemView.findViewById(R.id.tv_item_sale_time);
            date = itemView.findViewById(R.id.tv_item_sale_date);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view) {
            if (mClickListener != null) mClickListener.onItemClick(view, getAdapterPosition());
        }
    }

    // convenience method for getting data at click position
    UUID getId(int id) {
        return mData.get(id).getId();
    }

    // allows clicks events to be caught
    void setClickListener(SaleItemClickListener itemClickListener) {
        this.mClickListener = itemClickListener;
    }

    // parent activity will implement this method to respond to click events
    public interface SaleItemClickListener {
        void onItemClick(View view, int position);
    }


}
