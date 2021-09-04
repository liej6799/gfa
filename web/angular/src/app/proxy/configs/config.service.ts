import type { ConfigDto, CreateUpdateConfigDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ConfigService {
  apiName = 'Default';

  create = (input: CreateUpdateConfigDto) =>
    this.restService.request<any, ConfigDto>({
      method: 'POST',
      url: '/api/app/config',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/config/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ConfigDto>({
      method: 'GET',
      url: `/api/app/config/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ConfigDto>>({
      method: 'GET',
      url: '/api/app/config',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateConfigDto) =>
    this.restService.request<any, ConfigDto>({
      method: 'PUT',
      url: `/api/app/config/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
