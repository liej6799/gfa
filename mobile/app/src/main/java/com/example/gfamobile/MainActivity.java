package com.example.gfamobile;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.lifecycle.ViewModelProvider;

import android.os.Bundle;
import android.view.MenuItem;

import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.ui.auth.AuthViewModel;
import com.example.gfamobile.ui.home.HomeFragment;
import com.example.gfamobile.ui.item.ItemFragment;
import com.example.gfamobile.ui.item.ItemViewModel;
import com.example.gfamobile.ui.sale.SaleFragment;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.Objects;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.api.ItemApi;

public class MainActivity extends PortraitDaggerAppCompatActivity implements BottomNavigationView.OnNavigationItemSelectedListener {

    private BottomNavigationView bottomNavigationView;
    private ItemFragment itemFragment = new ItemFragment();
    private SaleFragment saleFragment = new SaleFragment();
    private HomeFragment homeFragment = new HomeFragment();

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
        if (item.getItemId() == R.id.home) {
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, homeFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Home");
            return true;
        }

        else if (item.getItemId() == R.id.item) {
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, itemFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Item");
            return true;
        }

        else if (item.getItemId() == R.id.sale) {
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, saleFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Sale");
            return true;
        }
        return false;
    }
}