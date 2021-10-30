import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { NgbdSortableHeader } from './NgbdSortableHeader';



@NgModule({
    declarations: [NgbdSortableHeader],
    exports: [
        NgbdSortableHeader
    ]
})
export class HelperModule { }
