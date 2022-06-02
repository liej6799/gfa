package com.example.gfamobile;

import androidx.annotation.NonNull;
import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.lifecycle.ViewModelProvider;

import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import com.daimajia.androidanimations.library.Techniques;
import com.daimajia.androidanimations.library.YoYo;
import com.example.gfamobile.data.model.Date;
import com.example.gfamobile.ui.PortraitDaggerAppCompatActivity;
import com.example.gfamobile.ui.auth.AuthViewModel;
import com.example.gfamobile.ui.home.HomeFragment;
import com.example.gfamobile.ui.item.ItemFragment;
import com.example.gfamobile.ui.item.ItemViewModel;
import com.example.gfamobile.ui.sale.SaleAdapter;
import com.example.gfamobile.ui.sale.SaleFragment;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.datepicker.MaterialDatePicker;
import com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener;

import java.util.Objects;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import io.swagger.client.ApiClient;
import io.swagger.client.api.ItemApi;

public class MainActivity extends PortraitDaggerAppCompatActivity implements BottomNavigationView.OnNavigationItemSelectedListener {

    private BottomNavigationView bottomNavigationView;
    private ItemFragment itemFragment = new ItemFragment();
    private SaleFragment saleFragment = new SaleFragment();
    private HomeFragment homeFragment = new HomeFragment();


    private static Date date = new Date();

    @BindView(R.id.cl_activity_main_header)
    ConstraintLayout cl_activity_main_header;

    @BindView(R.id.tv_activity_main_date)
    TextView tv_activity_main_date;

    @BindView(R.id.iv_activity_main_next_date)
    ImageView iv_activity_main_next_date;

    @BindView(R.id.iv_activity_main_prev_date)
    ImageView iv_activity_main_prev_date;

    private int selectedFragment;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ButterKnife.bind(this);
        getSupportActionBar().setElevation(0);

        bottomNavigationView = findViewById(R.id.bottomNavigationView);

        bottomNavigationView.setOnNavigationItemSelectedListener(this);
        selectedFragment = R.id.item;
        bottomNavigationView.setSelectedItemId(R.id.item);

        tv_activity_main_date.setText(date.getStartCalendar().toString("MMM d"));

        iv_activity_main_next_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                date.setNextDay();
                YoYo.with(Techniques.SlideInRight)
                        .duration(300)
                        .playOn(findViewById(R.id.tv_activity_main_date));
                tv_activity_main_date.setText(date.getStartCalendar().toString("MMM d"));
                updateFragment();
            }
        });

        iv_activity_main_prev_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                date.setPrevDay();
                YoYo.with(Techniques.SlideInLeft)
                        .duration(300)
                        .playOn(findViewById(R.id.tv_activity_main_date));
                tv_activity_main_date.setText(date.getStartCalendar().toString("MMM d"));
                updateFragment();
            }
        });

        tv_activity_main_date.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                MaterialDatePicker datePicker = MaterialDatePicker.Builder.datePicker()
                        .setTitleText("Select dates")
                        .setSelection(date.getStartCalendar().getMillis()).build();

                datePicker.show(getSupportFragmentManager(), "Datepickerdialog");

                datePicker.addOnPositiveButtonClickListener(new MaterialPickerOnPositiveButtonClickListener() {
                    @Override
                    public void onPositiveButtonClick(Object selection) {
                        date.setStartCalendar(Long.parseLong(selection.toString()));
                        date.setEndCalendar(Long.parseLong(selection.toString()));
                        tv_activity_main_date.setText(date.getStartCalendar().toString("MMM d"));
                    }
                });
            }
        });

    }

    private void updateFragment()
    {
        if (selectedFragment == R.id.home)
        {
            HomeFragment fragment = (HomeFragment) getSupportFragmentManager().findFragmentById(R.id.flFragment);
            fragment.setDate(date);
        }
        else if (selectedFragment == R.id.sale)
        {
            SaleFragment fragment = (SaleFragment) getSupportFragmentManager().findFragmentById(R.id.flFragment);
            fragment.setDate(date);
        }
    }
    public static Date getDate(){
        return date;
    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.home) {
            cl_activity_main_header.setVisibility(View.VISIBLE);
            selectedFragment = R.id.home;
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, homeFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Home");
            return true;
        }

        else if (item.getItemId() == R.id.item) {
            cl_activity_main_header.setVisibility(View.GONE);
            selectedFragment = R.id.item;
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, itemFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Item");
            return true;
        }

        else if (item.getItemId() == R.id.sale) {
            cl_activity_main_header.setVisibility(View.VISIBLE);
            selectedFragment = R.id.sale;
            getSupportFragmentManager().beginTransaction().replace(R.id.flFragment, saleFragment).commit();
            Objects.requireNonNull(getSupportActionBar()).setTitle("Sale");
            return true;
        }
        return false;
    }
}