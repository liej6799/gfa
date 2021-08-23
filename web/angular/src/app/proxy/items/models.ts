import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  name: string;
  code?: string;
  buyPrice: number;
  sellPrice: number;
  isUpdated: boolean;
}

export interface ItemDto extends AuditedEntityDto<string> {
  sourceId: number;
  name?: string;
  code?: string;
  buyPrice: number;
  sellPrice: number;
  isUpdated: boolean;
}
