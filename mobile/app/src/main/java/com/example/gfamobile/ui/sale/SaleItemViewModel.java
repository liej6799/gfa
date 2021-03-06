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
import io.swagger.client.api.SaleItemApi;
import io.swagger.client.model.GfaWebSalesSaleDto;
import io.swagger.client.model.GfaWebSalesSaleItemDto;
import needle.Needle;

public class SaleItemViewModel extends ViewModel {

    private SaleItemApi saleItemApi = new SaleItemApi();
    private MediatorLiveData<List<GfaWebSalesSaleItemDto>> saleItemMediatorLiveData = new MediatorLiveData<>();

    @Inject
    public SaleItemViewModel(ApiClient apiClient) {
        saleItemApi.setApiClient(apiClient);
    }


    public void getSaleItem(UUID saleId)
    {

        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebSalesSaleItemDto> result = saleItemApi.apiAppSaleItemNoPagedGet(saleId,
                        "dateSales desc");

                saleItemMediatorLiveData.postValue(result);
            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public void getSaleItemDateSummary(DateTime fromDate, DateTime toDate)
    {
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebSalesSaleItemDto> result = saleItemApi.apiAppSaleItemNoPagedDateSummaryGet(fromDate, toDate);

                saleItemMediatorLiveData.postValue(result);
            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public LiveData<List<GfaWebSalesSaleItemDto>> observeSaleItem() {

        return saleItemMediatorLiveData;
    }
}
