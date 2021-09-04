import type { AuditedEntityDto } from '@abp/ng.core';

export interface ConfigDto extends AuditedEntityDto<string> {
  name?: string;
  isDaily: boolean;
  isMonthly: boolean;
  isYearly: boolean;
  isAll: boolean;
  timerInMs: number;
}

export interface CreateUpdateConfigDto extends AuditedEntityDto<string> {
  name?: string;
  isDaily: boolean;
  isMonthly: boolean;
  isYearly: boolean;
  isAll: boolean;
  timerInMs: number;
}
