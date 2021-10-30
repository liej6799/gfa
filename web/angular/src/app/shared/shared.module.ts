import { CoreModule } from '@abp/ng.core';
import { NgbDropdownModule, NgbPaginationModule } from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { NgxValidateCoreModule } from '@ngx-validate/core';
import { NgbdSortableHeader } from '../helper/NgbdSortableHeader';
import { HelperModule } from '../helper/helper.module';

@NgModule({
  declarations: [],
  imports: [
    CoreModule,
    ThemeSharedModule,
    NgbDropdownModule,
    NgxValidateCoreModule,
    NgbPaginationModule,
    HelperModule
    
  ],
  exports: [
    CoreModule,
    ThemeSharedModule,
    NgbDropdownModule,
    NgxValidateCoreModule,
    NgbPaginationModule,
    HelperModule
    
  ],
  providers: []
})
export class SharedModule {}
