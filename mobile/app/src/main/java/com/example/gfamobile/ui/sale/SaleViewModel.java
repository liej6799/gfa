package com.example.gfamobile.ui.sale;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MediatorLiveData;
import androidx.lifecycle.ViewModel;

import com.example.gfamobile.data.model.Date;
import com.example.gfamobile.data.model.Sale;
import com.example.gfamobile.data.model.User;
import com.example.gfamobile.util.Resource;

import org.joda.time.DateTime;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

import java.util.ArrayList;
import java.util.List;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.api.ItemApi;
import io.swagger.client.api.SaleApi;
import io.swagger.client.model.GfaWebItemsCreateUpdateItemDto;
import io.swagger.client.model.GfaWebSalesCreateUpdateSaleDto;
import io.swagger.client.model.GfaWebSalesSaleDto;
import needle.Needle;

public class SaleViewModel extends ViewModel
{

    private SaleApi saleApi = new SaleApi();
    private MediatorLiveData<List<Sale>> saleMediatorLiveData = new MediatorLiveData<>();

    @Inject
    public SaleViewModel(ApiClient apiClient) {
        saleApi.setApiClient(apiClient);
    }


    public void getSales(Date date)
    {
        List<Sale> saleList = new ArrayList<>();

        DateTime fromDate = new DateTime(date.getStartYear(), date.getStartMonth(), date.getStartDayOfMonth() + 1, 0, 0, 0);
        DateTime toDate = new DateTime(date.getEndYear(), date.getEndMonth(), date.getEndDayOfMonth() + 1, 0, 0, 0);
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebSalesSaleDto> result = saleApi.apiAppSaleNoPagedGet(fromDate, toDate,
                        "dateSales desc");

                for (GfaWebSalesSaleDto rawSale : result)
                {
                    saleList.add(new Sale(rawSale.getTotalAmount(), rawSale.getDateSales()));
                }

                saleMediatorLiveData.postValue(saleList);
            } catch (ApiException e) {
                e.printStackTrace();
            }
        });



    }

    public LiveData<List<Sale>> observeSale() {

        return saleMediatorLiveData;
    }

}
