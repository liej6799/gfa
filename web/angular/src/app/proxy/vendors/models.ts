import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateVendorDto extends AuditedEntityDto<string> {
  sourceId: number;
  name?: string;
}

export interface VendorDto extends AuditedEntityDto<string> {
  sourceId: number;
  name?: string;
}
