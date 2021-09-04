import type { AuditedEntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

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

export interface GetItemPurchaseHistoryInput extends PagedAndSortedResultRequestDto {
  itemId?: string;
}

export interface GetPurchaseItemInput extends PagedAndSortedResultRequestDto {
  purchaseId?: string;
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
