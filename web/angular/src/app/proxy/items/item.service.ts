import type { CreateUpdateItemDto, GetItemInput, ItemDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ItemService {
  apiName = 'Default';

  batchInsertByCreateUpdateItemDto = (createUpdateItemDto: CreateUpdateItemDto[]) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/item/batch-insert',
      body: createUpdateItemDto,
    },
    { apiName: this.apiName });

  create = (input: CreateUpdateItemDto) =>
    this.restService.request<any, ItemDto>({
      method: 'POST',
      url: '/api/app/item',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/item/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ItemDto>({
      method: 'GET',
      url: `/api/app/item/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ItemDto>>({
      method: 'GET',
      url: '/api/app/item',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  getListFilter = (input: GetItemInput) =>
    this.restService.request<any, PagedResultDto<ItemDto>>({
      method: 'GET',
      url: '/api/app/item/filter',
      params: { filter: input.filter, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  getListNoPaged = () =>
    this.restService.request<any, CreateUpdateItemDto[]>({
      method: 'GET',
      url: '/api/app/item/no-paged',
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateItemDto) =>
    this.restService.request<any, ItemDto>({
      method: 'PUT',
      url: `/api/app/item/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
