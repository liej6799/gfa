package com.example.gfamobile.ui.home;

import androidx.lifecycle.ViewModel;

import java.util.List;

import javax.inject.Inject;

import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.api.ItemApi;
import io.swagger.client.model.GfaWebItemsCreateUpdateItemDto;
import needle.Needle;

public class HomeViewModel extends ViewModel
{

    private ItemApi itemApi = new ItemApi();

    @Inject
    public HomeViewModel(ApiClient apiClient) {
        itemApi.setApiClient(apiClient);
    }


    public void getItemCount()
    {
        Needle.onBackgroundThread().execute(() -> {
            try {
                List<GfaWebItemsCreateUpdateItemDto> result = itemApi.apiAppItemNoPagedGet();
                result.size();

            } catch (ApiException e) {
                e.printStackTrace();
            }
        });


    }

}
