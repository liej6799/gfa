import { NgModule } from '@angular/core';

import {  ItemQuantityTrackerComponent } from './item-quantity-tracker.component';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [
    ItemQuantityTrackerComponent,
  ],
  imports: [
    SharedModule
  ],
  exports: [
    ItemQuantityTrackerComponent,
    SharedModule
  ]
})
export class ItemQuantityTrackerModule { }
