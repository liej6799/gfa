import { NgModule } from '@angular/core';

import {  ItemQuantityTrackerComponent } from './item-quantity-tracker.component';
import { SharedModule } from '../../shared/shared.module';
import {NgbAlertModule} from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    ItemQuantityTrackerComponent,
  ],
  imports: [
    SharedModule,
    NgbAlertModule
  ],
  exports: [
    ItemQuantityTrackerComponent,
    SharedModule
  ]
})
export class ItemQuantityTrackerModule { }
