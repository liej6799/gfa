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

import io.swagger.client.model.GfaWebSalesCreateUpdateSaleDto;
import io.swagger.client.model.GfaWebSalesSaleDto;

public class SaleAdapter extends RecyclerView.Adapter<SaleAdapter.ViewHolder> {

    private final List<GfaWebSalesCreateUpdateSaleDto> mData;
    private final LayoutInflater mInflater;
    private SaleItemClickListener mClickListener;

    private static final int LIST_VIEW = 1;
    private static final int HEADER_LIST_VIEW = 2;


    // data is passed into the constructor
    SaleAdapter(Context context, List<GfaWebSalesCreateUpdateSaleDto> data) {
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
        GfaWebSalesCreateUpdateSaleDto sale = mData.get(position);
        holder.time.setText(sale.getDateSales().toString("hh:mm a"));
        holder.short_name.setText(sale.getShortName());
        holder.total.setText(String.valueOf(Helper.GetCurrencyHelper().format(sale.getTotalAmount())));
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener {
        TextView total;
        TextView time;
        TextView short_name;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            total = itemView.findViewById(R.id.tv_item_sale_total);
            time = itemView.findViewById(R.id.tv_item_sale_time);
            short_name = itemView.findViewById(R.id.tv_item_sale_short_name);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view) {
            if (mClickListener != null) mClickListener.onItemClick(view, getAdapterPosition());
        }
    }

    @Override
    public int getItemViewType(int position) {

        int firstListSize = 0;

        if (mData == null)
            return super.getItemViewType(position);

        if (mData != null)
            firstListSize = mData.size();

        if (firstListSize > 0) {
            if (position == 0) return HEADER_LIST_VIEW;
            else return LIST_VIEW;

        }

        return super.getItemViewType(position);
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
