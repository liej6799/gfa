package com.example.gfamobile.ui.item;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.gfamobile.R;
import com.example.gfamobile.ui.sale.SaleAdapter;
import com.example.gfamobile.util.Helper;

import java.util.List;
import java.util.UUID;

import io.swagger.client.model.GfaWebItemsCreateUpdateItemDto;
import io.swagger.client.model.GfaWebSalesCreateUpdateSaleDto;


public class ItemAdapter extends RecyclerView.Adapter<ItemAdapter.ViewHolder> {


    private final List<GfaWebItemsCreateUpdateItemDto> mData;
    private final LayoutInflater mInflater;
    private ItemAdapter.ItemClickListener mClickListener;

    // data is passed into the constructor
    ItemAdapter(Context context, List<GfaWebItemsCreateUpdateItemDto> data) {
        this.mInflater = LayoutInflater.from(context);
        this.mData = data;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = mInflater.inflate(R.layout.item_item, parent, false);
        return new ItemAdapter.ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        GfaWebItemsCreateUpdateItemDto item = mData.get(position);
        holder.name.setText(item.getName());
        holder.code.setText(item.getCode());
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }


    public class ViewHolder extends RecyclerView.ViewHolder  implements View.OnClickListener {
        TextView name;
        TextView code;
        TextView qty;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            name = itemView.findViewById(R.id.tv_item_name);
            code = itemView.findViewById(R.id.tv_item_code);
            qty = itemView.findViewById(R.id.tv_item_qty);
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
    void setClickListener(ItemAdapter.ItemClickListener itemClickListener) {
        this.mClickListener = itemClickListener;
    }

    // parent activity will implement this method to respond to click events
    public interface ItemClickListener {
        void onItemClick(View view, int position);
    }
}
