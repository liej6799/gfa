package com.example.gfamobile.ui.home;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.TextView;

import com.example.gfamobile.MainActivity;
import com.example.gfamobile.R;
import com.example.gfamobile.data.model.Date;
import com.example.gfamobile.ui.sale.SaleAdapter;
import com.example.gfamobile.ui.sale.SaleFragment;
import com.example.gfamobile.ui.sale.SaleViewModel;
import com.example.gfamobile.util.Helper;
import com.example.gfamobile.util.ViewModelProviderFactory;
import com.github.mikephil.charting.charts.BarChart;
import com.github.mikephil.charting.components.XAxis;
import com.github.mikephil.charting.components.YAxis;
import com.github.mikephil.charting.data.BarData;
import com.github.mikephil.charting.data.BarDataSet;
import com.github.mikephil.charting.data.BarEntry;
import com.github.mikephil.charting.formatter.ValueFormatter;
import com.github.mikephil.charting.interfaces.datasets.IBarDataSet;
import com.github.mikephil.charting.listener.ChartTouchListener;
import com.github.mikephil.charting.listener.OnChartGestureListener;
import com.squareup.okhttp.internal.Util;
import com.wdullaer.materialdatetimepicker.date.DatePickerDialog;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.Random;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import dagger.android.support.DaggerFragment;
import io.swagger.client.model.GfaWebSalesCreateUpdateSaleDto;

public class HomeFragment extends DaggerFragment implements OnChartGestureListener, DatePickerDialog.OnDateSetListener {

    private static final ArrayList<String> HOUR = new ArrayList<>();


    @BindView(R.id.fragment_verticalbarchart_chart)
    BarChart chart;
    @BindView(R.id.et_sale_summary_start_date)
    EditText et_sale_summary_start_date;

    @BindView(R.id.tv_home_total_sales)
    TextView tv_home_total_sales;


    private SaleViewModel saleViewModel;

    private Date date = new Date();

    private boolean isStartDateSelected = false;

    @Inject
    ViewModelProviderFactory viewModelProviderFactory;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_home, container, false);
        ButterKnife.bind(this, view);
        HOUR.clear();
        saleViewModel = new ViewModelProvider(this, viewModelProviderFactory).get(SaleViewModel.class);


        et_sale_summary_start_date.setText(String.format("%d/%d/%d", date.getStartCalendar().getDayOfMonth(), date.getStartCalendar().getMonthOfYear(), date.getStartCalendar().getYear()));
        saleViewModel.getSalesSumamry(date);
        listener();
        return view;
    }
    private void listener()
    {
        saleViewModel.observeSaleGroupGraphs().observe(getViewLifecycleOwner(), saleList -> {
            if (saleList != null) {

                BarData data = createChartData(saleList);
                configureChartAppearance();
                prepareChartData(data);
            }
        });

        saleViewModel.observeSaleGroupSummaryTotal().observe(getViewLifecycleOwner(), saleList -> {
            if (saleList != null) {
                if (saleList.size() > 0)
                {
                    tv_home_total_sales.setText(String.valueOf(Helper.GetCurrencyHelper().format(saleList.get(0).getTotalAmount())));
                }
            }

        });



        et_sale_summary_start_date.setOnClickListener(v -> {

            DatePickerDialog dpd = DatePickerDialog.newInstance(
                    HomeFragment.this,
                    date.getStartCalendar().getYear(),
                    date.getStartCalendar().getMonthOfYear() - 1,
                    date.getStartCalendar().getDayOfMonth()// Inital day selection
            );

            dpd.show(getFragmentManager(), "Datepickerdialog");
            dpd.setAccentColor(getResources().getColor(R.color.mdtp_accent_color_dark));
            isStartDateSelected = true;
        });
    }
    private BarData createChartData(List<GfaWebSalesCreateUpdateSaleDto> saleDtos) {
        ArrayList<BarEntry> values = new ArrayList<>();

        for (int i = 0; i < saleDtos.size(); i++)
        {
            values.add(new BarEntry(i, saleDtos.get(i).getTotalAmount().floatValue()));
            HOUR.add(saleDtos.get(i).getDateSales().toString("hh a"));
        }

        BarDataSet set1 = new BarDataSet(values, "Sales");

        ArrayList<IBarDataSet> dataSets = new ArrayList<>();
        dataSets.add(set1);

        BarData data = new BarData(dataSets);

        return data;
    }

    private void configureChartAppearance() {
        chart.getLegend().setEnabled(false);
        chart.getDescription().setEnabled(false);

        chart.setOnChartGestureListener(this);
        XAxis xAxis = chart.getXAxis();
        xAxis.setValueFormatter(new ValueFormatter() {
            @Override
            public String getFormattedValue(float value) {
                return HOUR.get((int) value);
            }
        });

        chart.getXAxis().setPosition(XAxis.XAxisPosition.BOTTOM);

        YAxis axisLeft = chart.getAxisLeft();
        axisLeft.setGranularity(10f);
        axisLeft.setAxisMinimum(0);

        YAxis axisRight = chart.getAxisRight();
        axisRight.setGranularity(10f);
        axisRight.setAxisMinimum(0);

        axisRight.setEnabled(false);

    }

    private void prepareChartData(BarData data) {
        data.setValueTextSize(12f);
        chart.setData(data);
        chart.invalidate();
    }

    @Override
    public void onChartGestureStart(MotionEvent me, ChartTouchListener.ChartGesture lastPerformedGesture) {

    }

    @Override
    public void onChartGestureEnd(MotionEvent me, ChartTouchListener.ChartGesture lastPerformedGesture) {

    }

    @Override
    public void onChartLongPressed(MotionEvent me) {

    }

    @Override
    public void onChartDoubleTapped(MotionEvent me) {

    }

    @Override
    public void onChartSingleTapped(MotionEvent me) {

    }

    @Override
    public void onChartFling(MotionEvent me1, MotionEvent me2, float velocityX, float velocityY) {

    }

    @Override
    public void onChartScale(MotionEvent me, float scaleX, float scaleY) {

    }

    @Override
    public void onChartTranslate(MotionEvent me, float dX, float dY) {

    }

    @Override
    public void onDateSet(DatePickerDialog view, int year, int monthOfYear, int dayOfMonth) {
        if (isStartDateSelected)
        {
            isStartDateSelected = false;

            date.setStartCalendar(year, monthOfYear + 1, dayOfMonth);
            date.setEndCalendar(year, monthOfYear + 1, dayOfMonth);
            et_sale_summary_start_date.setText(String.format("%d/%d/%d", date.getStartCalendar().getDayOfMonth(), date.getStartCalendar().getMonthOfYear(), date.getStartCalendar().getYear()));
            saleViewModel.getSalesSumamry(date);
        }
    }
}