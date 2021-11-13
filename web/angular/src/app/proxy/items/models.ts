import type { AuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface CreateUpdateItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  name: string;
  code?: string;
  buyPrice: number;
  sellPrice: number;
  profitLoss: number;
}

export interface GetItemInput extends PagedAndSortedResultRequestDto {
  filter?: string;
}

export interface GetQuantityTrackerInput extends PagedAndSortedResultRequestDto {
  itemId?: string;
}

export interface ItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  name?: string;
  code?: string;
  buyPrice: number;
  sellPrice: number;
  profitLoss: number;
  quantity: number;
  date?: string;
  remaining: number;
  salePurchaseId?: string;
}
