package com.example.gfamobile.ui.sale;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MediatorLiveData;
import androidx.lifecycle.ViewModel;

import com.example.gfamobile.data.model.Date;

import org.joda.time.DateTime;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.api.SaleApi;
import io.swagger.client.model.GfaWebSalesSaleDto;
import needle.Needle;

public class SaleViewModel extends ViewModel
{

    private SaleApi saleApi = new SaleApi();
    private MediatorLiveData<List<GfaWebSalesSaleDto>> saleListMediatorLiveData = new MediatorLiveData<>();
    private MediatorLiveData<GfaWebSalesSaleDto> saleMediatorLiveData = new MediatorLiveData<>();

    @Inject
    public SaleViewModel(ApiClient apiClient) {
        saleApi.setApiClient(apiClient);
    }


    public void getSales(Date date)
    {
        DateTime fromDate = new DateTime(date.getStartYear(), date.getStartMonth(), date.getStartDayOfMonth() + 1, 0, 0, 0);
        DateTime toDate = new DateTime(date.getEndYear(), date.getEndMonth(), date.getEndDayOfMonth() + 1, 0, 0, 0);
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebSalesSaleDto> result = saleApi.apiAppSaleNoPagedGet(fromDate, toDate,
                        "dateSales desc");

                saleListMediatorLiveData.postValue(result);
            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public void getSalesId(UUID saleId)
    {
        Needle.onBackgroundThread().execute(() -> {
            try {
                GfaWebSalesSaleDto result = saleApi.apiAppSaleIdGet(saleId);

                saleMediatorLiveData.postValue(result);
            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public LiveData<List<GfaWebSalesSaleDto>> observeSaleList() {

        return saleListMediatorLiveData;
    }
    public LiveData<GfaWebSalesSaleDto> observeSaleId() {

        return saleMediatorLiveData;
    }
}
