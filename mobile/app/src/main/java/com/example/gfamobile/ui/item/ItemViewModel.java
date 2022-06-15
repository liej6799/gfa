package com.example.gfamobile.ui.item;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MediatorLiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

import java.util.List;
import java.util.UUID;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.api.ItemApi;
import io.swagger.client.model.GfaWebItemsCreateUpdateItemDto;
import io.swagger.client.model.GfaWebItemsItemDto;
import io.swagger.client.model.GfaWebSalesCreateUpdateSaleDto;
import needle.Needle;

public class ItemViewModel extends ViewModel
{
    private MediatorLiveData<List<GfaWebItemsCreateUpdateItemDto>> itemListMediatorLiveData = new MediatorLiveData<>();
    private MediatorLiveData<GfaWebItemsItemDto> itemMediatorLiveData = new MediatorLiveData<>();

    private ItemApi itemApi = new ItemApi();

    @Inject
    public ItemViewModel(ApiClient apiClient) {
        itemApi.setApiClient(apiClient);
    }


    public void getAllItem(String inputQuery)
    {
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebItemsCreateUpdateItemDto> result = itemApi.apiAppItemNoPagedFilterGet(inputQuery);
                itemListMediatorLiveData.postValue(result);

            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public void getItem(UUID itemId)
    {
        Needle.onBackgroundThread().execute(() -> {
            try {
                GfaWebItemsItemDto result = itemApi.apiAppItemIdGet(itemId);
                itemMediatorLiveData.postValue(result);

            } catch (ApiException e) {
                e.printStackTrace();
            }
        });
    }

    public LiveData<List<GfaWebItemsCreateUpdateItemDto>> observeAllItem() {
        return itemListMediatorLiveData;
    }

    public LiveData<GfaWebItemsItemDto> observeItem() {
        return itemMediatorLiveData;
    }
}
