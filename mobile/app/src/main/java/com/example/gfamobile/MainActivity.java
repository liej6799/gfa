package com.example.gfamobile;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.lifecycle.ViewModelProvider;

import android.os.Bundle;
import android.view.MenuItem;

import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.ui.auth.AuthViewModel;
import com.example.gfamobile.ui.item.ItemFragment;
import com.example.gfamobile.ui.item.ItemViewModel;
import com.example.gfamobile.ui.sale.SaleFragment;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.api.ItemApi;

public class MainActivity extends PortraitDaggerAppCompatActivity implements BottomNavigationView.OnNavigationItemSelectedListener {

    private BottomNavigationView bottomNavigationView;
    private ItemFragment itemFragment = new ItemFragment();
    private SaleFragment saleFragment = new SaleFragment();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bottomNavigationView = findViewById(R.id.bottomNavigationView);

        bottomNavigationView.setOnNavigationItemSelectedListener(this);
        bottomNavigationView.setSelectedItemId(R.id.item);
    }


    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.item) {
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, itemFragment).commit();
            return true;
        }

        else if (item.getItemId() == R.id.sale) {
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, saleFragment).commit();
            return true;
        }
        return false;
    }
}