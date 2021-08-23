import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { ItemRoutingModule } from './item-routing.module';
import { ItemComponent } from './item.component';


@NgModule({
  declarations: [
    ItemComponent
  ],
  imports: [
    SharedModule,
    ItemRoutingModule
  ]
})
export class ItemModule { }
