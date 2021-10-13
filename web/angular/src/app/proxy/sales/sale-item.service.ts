import type { CreateUpdateSaleItemDto, GetSaleItemInput, GetSalesItemHistoryInput, SaleItemDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SaleItemService {
  apiName = 'Default';

  batchInsertByCreateUpdateSaleItemDtos = (createUpdateSaleItemDtos: CreateUpdateSaleItemDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/sale-item/batch-insert',
      body: createUpdateSaleItemDtos,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdateSaleItemDto) =>
    this.restService.request<any, SaleItemDto>({
      method: 'POST',
      url: '/api/app/sale-item',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/sale-item/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SaleItemDto>({
      method: 'GET',
      url: `/api/app/sale-item/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: GetSaleItemInput) =>
    this.restService.request<any, PagedResultDto<SaleItemDto>>({
      method: 'GET',
      url: '/api/app/sale-item',
      params: { saleId: input.saleId, filter: input.filter, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getListNoPaged = () =>
    this.restService.request<any, CreateUpdateSaleItemDto[]>({
      method: 'GET',
      url: '/api/app/sale-item/no-paged',
    },
    { apiName: this.apiName });

  getSalesItemHistoryList = (input: GetSalesItemHistoryInput) =>
    this.restService.request<any, PagedResultDto<SaleItemDto>>({
      method: 'GET',
      url: '/api/app/sale-item/sales-item-history-list',
      params: { itemId: input.itemId, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSaleItemDto) =>
    this.restService.request<any, SaleItemDto>({
      method: 'PUT',
      url: `/api/app/sale-item/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
