package com.example.gfamobile.ui.sale;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MediatorLiveData;
import androidx.lifecycle.ViewModel;

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
import needle.Needle;

public class SaleViewModel extends ViewModel
{

    private SaleApi saleApi = new SaleApi();
    private MediatorLiveData<List<Sale>> saleMediatorLiveData = new MediatorLiveData<>();

    @Inject
    public SaleViewModel(ApiClient apiClient) {
        saleApi.setApiClient(apiClient);
    }


    public void getSales()
    {
        DateTimeFormatter df = DateTimeFormat.forPattern("dd/MM/yyyy");
        DateTime fromDate = df.parseDateTime("22/05/2022");
        DateTime toDate = df.parseDateTime("22/05/2022");
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebSalesCreateUpdateSaleDto> result = saleApi.apiAppSaleNoPagedGet(fromDate, toDate,
                        "asc", 0, 5);

                List<Sale> saleList = new ArrayList<>();
                for (GfaWebSalesCreateUpdateSaleDto rawSale : result)
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
