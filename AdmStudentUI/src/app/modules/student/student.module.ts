import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentListComponent } from '../student/components/student-list/student-list.component';
import { StudentCardComponent } from '../student/components/student-card/student-card.component';
import {AppRoutingModule} from './student-routing.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  declarations: [StudentCardComponent, StudentListComponent],
  imports: [
    CommonModule,
    AppRoutingModule,
    TranslateModule
  ]
})
export class StudentModule { }
