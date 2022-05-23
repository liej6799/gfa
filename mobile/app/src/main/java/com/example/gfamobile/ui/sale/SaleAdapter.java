package com.example.gfamobile.ui.sale;

import android.content.ClipData;
import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;

import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Sale;

import java.text.NumberFormat;
import java.util.Currency;
import java.util.List;

public class SaleAdapter extends RecyclerView.Adapter<SaleAdapter.ViewHolder> {

    private final List<Sale> mData;
    private final LayoutInflater mInflater;


    // data is passed into the constructor
    SaleAdapter(Context context, List<Sale> data) {
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
        Sale sale = mData.get(position);
        holder.time.setText(sale.getDateSale().toString("hh:mm a"));
        holder.date.setText(sale.getDateSale().toString("EEE, dd MMM, yyyy"));

        NumberFormat format = NumberFormat.getCurrencyInstance();
        format.setMaximumFractionDigits(0);
        format.setCurrency(Currency.getInstance("IDR"));

        holder.total.setText(String.valueOf(format.format(sale.getTotal())));
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

        }
    }


}
