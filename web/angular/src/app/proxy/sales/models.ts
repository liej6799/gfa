import type { AuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface CreateUpdateSaleDto extends AuditedEntityDto<string> {
  sourceId: number;
  dateSales?: string;
  totalAmount: number;
  totalCash: number;
  totalChange: number;
}

export interface CreateUpdateSaleItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  quantity: number;
  price: number;
  total: number;
  itemId?: string;
  saleId?: string;
  itemSourceId: number;
  saleSourceId: number;
}

export interface GetItemHistoryInput extends PagedAndSortedResultRequestDto {
  itemId?: string;
}

export interface GetSaleInput extends PagedAndSortedResultRequestDto {
  startDate: string;
  endDate: string;
}

export interface GetSaleItemInput extends PagedAndSortedResultRequestDto {
  saleId?: string;
  filter?: string;
}

export interface SaleDto extends AuditedEntityDto<string> {
  sourceId: number;
  dateSales?: string;
  totalAmount: number;
  totalCash: number;
  totalChange: number;
}

export interface SaleItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  quantity: number;
  price: number;
  total: number;
  itemId?: string;
  saleId?: string;
  itemName?: string;
  currentBuyPrice: number;
  dateSales?: string;
}
