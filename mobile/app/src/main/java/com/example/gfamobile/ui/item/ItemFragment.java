package com.example.gfamobile.ui.item;

import static com.example.gfamobile.util.Intent.ITEM_DETAIL;
import static com.example.gfamobile.util.Intent.ITEM_DETAIL_ID;

import android.content.Intent;
import android.os.Bundle;

import androidx.lifecycle.ViewModelProvider;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.gfamobile.R;
import com.example.gfamobile.util.ViewModelProviderFactory;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import dagger.android.support.DaggerFragment;

public class ItemFragment extends DaggerFragment implements ItemAdapter.ItemClickListener {

    private ItemViewModel itemViewModel;
    private ItemAdapter itemAdapter;
    private String query;

    @BindView(R.id.rv_item)
    RecyclerView rv_item;

    @BindView(R.id.srl_item)
    SwipeRefreshLayout srl_item;


    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_item, container, false);
        ButterKnife.bind(this, view);


        itemViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(ItemViewModel.class);
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());
        rv_item.setLayoutManager(linearLayoutManager);
        itemViewModel.getAllItem(query);
        listener();
        return view;
    }

    public void setSearchQuery(String inputQuery)
    {
        query = inputQuery;
        itemViewModel.getAllItem(query);
    }

    private void listener()
    {
        itemViewModel.observeAllItem().observe(getViewLifecycleOwner(), itemList -> {
            if (itemList != null) {
                itemAdapter = new ItemAdapter(getContext(), itemList);
                rv_item.setAdapter(itemAdapter);
                itemAdapter.setClickListener(this);

                srl_item.setRefreshing(false);
            }
        });

        srl_item.setOnRefreshListener(() -> itemViewModel.getAllItem(query));
    }

    @Override
    public void onItemClick(View view, int position) {
        Intent intent = new Intent(getActivity(), ItemDetailsActivity.class);
        intent.putExtra(ITEM_DETAIL,true);
        intent.putExtra(ITEM_DETAIL_ID, itemAdapter.getId(position).toString());
        startActivity(intent);
    }
}