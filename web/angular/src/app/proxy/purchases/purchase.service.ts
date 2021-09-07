import type { CreateUpdatePurchaseDto, GetPurchaseInput, PurchaseDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PurchaseService {
  apiName = 'Default';

  batchInsertByCreateUpdateVendorDto = (createUpdateVendorDto: CreateUpdatePurchaseDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/purchase/batch-insert',
      body: createUpdateVendorDto,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'POST',
      url: '/api/app/purchase',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/purchase/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PurchaseDto>({
      method: 'GET',
      url: `/api/app/purchase/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: GetPurchaseInput) =>
    this.restService.request<any, PagedResultDto<PurchaseDto>>({
      method: 'GET',
      url: '/api/app/purchase',
      params: { startDate: input.startDate, endDate: input.endDate, groupBy: input.groupBy, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getListNoPaged = () =>
    this.restService.request<any, CreateUpdatePurchaseDto[]>({
      method: 'GET',
      url: '/api/app/purchase/no-paged',
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdatePurchaseDto) =>
    this.restService.request<any, PurchaseDto>({
      method: 'PUT',
      url: `/api/app/purchase/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
