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
        holder.time.setText(sale.getTimeSale());
        holder.date.setText(sale.getDateSale());
        holder.total.setText(String.valueOf(sale.getTotal()));

        boolean isExpanded = sale.isExpanded();
        holder.linearLayout.setVisibility(isExpanded ?
                View.VISIBLE :
                View.GONE);
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener {
        TextView total;
        TextView time;
        TextView date;

        LinearLayout linearLayout;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            total = itemView.findViewById(R.id.tv_item_sale_total);
            time = itemView.findViewById(R.id.tv_item_sale_time);
            date = itemView.findViewById(R.id.tv_item_sale_date);
            linearLayout = itemView.findViewById(R.id.ll_item_sale_item);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view) {

            Sale sale = mData.get(getAdapterPosition());
            sale.setExpanded(!sale.isExpanded());
            notifyItemChanged(getAdapterPosition());
        }
    }


}
