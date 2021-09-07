import type { AuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import type { PurchaseGroup } from './purchase-group.enum';

export interface CreateUpdatePurchaseDto extends AuditedEntityDto<string> {
  sourceId: number;
  datePurchase?: string;
  vendorId?: string;
  vendorSourceId: number;
  totalAmount: number;
}

export interface CreateUpdatePurchaseItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  quantity: number;
  price: number;
  total: number;
  itemId?: string;
  itemSourceId: number;
  purchaseId?: string;
  purchaseSourceId: number;
}

export interface GetPurchaseInput extends PagedAndSortedResultRequestDto {
  startDate: string;
  endDate: string;
  groupBy: PurchaseGroup;
}

export interface GetPurchaseItemInput extends PagedAndSortedResultRequestDto {
  purchaseId?: string;
}

export interface GetPurchaseItemInputHistory extends PagedAndSortedResultRequestDto {
  itemId?: string;
}

export interface PurchaseDto extends AuditedEntityDto<string> {
  sourceId: number;
  datePurchase?: string;
  vendorId?: string;
  vendorName?: string;
  totalAmount: number;
}

export interface PurchaseItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  quantity: number;
  price: number;
  total: number;
  itemId?: string;
  itemName?: string;
  datePurchase?: string;
  currentBuyPrice: number;
  purchaseId?: string;
}
