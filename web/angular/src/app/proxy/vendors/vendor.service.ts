import type { CreateUpdateVendorDto, VendorDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class VendorService {
  apiName = 'Default';

  batchInsertByCreateUpdateVendorDto = (createUpdateVendorDto: CreateUpdateVendorDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/vendor/batch-insert',
      body: createUpdateVendorDto,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdateVendorDto) =>
    this.restService.request<any, VendorDto>({
      method: 'POST',
      url: '/api/app/vendor',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/vendor/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, VendorDto>({
      method: 'GET',
      url: `/api/app/vendor/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<VendorDto>>({
      method: 'GET',
      url: '/api/app/vendor',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getListNoPaged = () =>
    this.restService.request<any, CreateUpdateVendorDto[]>({
      method: 'GET',
      url: '/api/app/vendor/no-paged',
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateVendorDto) =>
    this.restService.request<any, VendorDto>({
      method: 'PUT',
      url: `/api/app/vendor/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
