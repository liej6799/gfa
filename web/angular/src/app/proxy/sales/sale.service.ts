import type { CreateUpdateSaleDto, GetSaleInput, SaleDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SaleService {
  apiName = 'Default';

  batchInsertByCreateUpdateSaleDtos = (createUpdateSaleDtos: CreateUpdateSaleDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/sale/batch-insert',
      body: createUpdateSaleDtos,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdateSaleDto) =>
    this.restService.request<any, SaleDto>({
      method: 'POST',
      url: '/api/app/sale',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/sale/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SaleDto>({
      method: 'GET',
      url: `/api/app/sale/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: GetSaleInput) =>
    this.restService.request<any, PagedResultDto<SaleDto>>({
      method: 'GET',
      url: '/api/app/sale',
      params: { startDate: input.startDate, endDate: input.endDate, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getListNoPagedByInput = (input: GetSaleInput) =>
    this.restService.request<any, CreateUpdateSaleDto[]>({
      method: 'GET',
      url: '/api/app/sale/no-paged',
      params: { startDate: input.startDate, endDate: input.endDate, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSaleDto) =>
    this.restService.request<any, SaleDto>({
      method: 'PUT',
      url: `/api/app/sale/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
