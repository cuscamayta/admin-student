import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { StudentListComponent } from './modules/student/components/student-list/student-list.component';
import { StudentCardComponent } from './modules/student/components/student-card/student-card.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentListComponent,
    StudentCardComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
