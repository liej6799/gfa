import { mapEnumToOptions } from '@abp/ng.core';

export enum PurchaseGroup {
  None = 0,
  Vendor = 1,
}

export const purchaseGroupOptions = mapEnumToOptions(PurchaseGroup);
