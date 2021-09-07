import type { CreateUpdatePurchaseItemDto, GetPurchaseItemInput, GetPurchaseItemInputHistory, PurchaseItemDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PurchaseItemService {
  apiName = 'Default';

  batchInsertByCreateUpdatePurchaseItemDtos = (createUpdatePurchaseItemDtos: CreateUpdatePurchaseItemDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/purchase-item/batch-insert',
      body: createUpdatePurchaseItemDtos,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdatePurchaseItemDto) =>
    this.restService.request<any, PurchaseItemDto>({
      method: 'POST',
      url: '/api/app/purchase-item',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/purchase-item/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PurchaseItemDto>({
      method: 'GET',
      url: `/api/app/purchase-item/${id}`,
    },
    { apiName: this.apiName });

  getItemPurchaseHistoryList = (input: GetPurchaseItemInputHistory) =>
    this.restService.request<any, PagedResultDto<PurchaseItemDto>>({
      method: 'GET',
      url: '/api/app/purchase-item/item-purchase-history-list',
      params: { itemId: input.itemId, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PurchaseItemDto>>({
      method: 'GET',
      url: '/api/app/purchase-item',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getListFilter = (input: GetPurchaseItemInput) =>
    this.restService.request<any, PagedResultDto<PurchaseItemDto>>({
      method: 'GET',
      url: '/api/app/purchase-item/filter',
      params: { purchaseId: input.purchaseId, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getListNoPaged = () =>
    this.restService.request<any, CreateUpdatePurchaseItemDto[]>({
      method: 'GET',
      url: '/api/app/purchase-item/no-paged',
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdatePurchaseItemDto) =>
    this.restService.request<any, PurchaseItemDto>({
      method: 'PUT',
      url: `/api/app/purchase-item/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
