package com.example.gfamobile.ui.sale;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Sale;
import com.example.gfamobile.data.model.SaleItem;

import java.util.ArrayList;

import butterknife.BindView;
import butterknife.ButterKnife;

public class SaleFragment extends Fragment {


    SaleAdapter saleAdapter;
    SaleItemAdapter saleItemAdapter;

    public SaleFragment() {
        // require a empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        View view = inflater.inflate(R.layout.fragment_sale, container, false);

        // data to populate the RecyclerView with
        ArrayList<Sale> animalNames = new ArrayList<>();

        animalNames.add(new Sale(2000, "2022-05-22", "14:05:00"));
        animalNames.add(new Sale(3000, "2022-05-22", "14:05:00"));
        animalNames.add(new Sale(5000, "2022-05-22", "14:05:00"));
        animalNames.add(new Sale(6000, "2022-05-22", "14:05:00"));

        ArrayList<SaleItem> saleItem = new ArrayList<>();

        saleItem.add(new SaleItem(1, "Rinso", 25000, 25000));

        RecyclerView recyclerView = (RecyclerView) view.findViewById(R.id.rv_item_sale);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));
        saleAdapter = new SaleAdapter(getContext(), animalNames);
        recyclerView.setAdapter(saleAdapter);

        return view;
    }
}