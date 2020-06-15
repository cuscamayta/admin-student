import { NgModule } from '@angular/core';
import {
    MatSidenavModule, MatToolbarModule, MatIconModule, MatListModule, MatFormFieldModule,
    MatCheckboxModule, MatMenuModule, MatBadgeModule, MatTabsModule, MatSnackBarModule,
    MatSlideToggleModule
} from '@angular/material';

@NgModule({
    imports: [
        MatSidenavModule,
        MatToolbarModule,
        MatIconModule,
        MatListModule,
        MatFormFieldModule,
        MatCheckboxModule,
        MatMenuModule,
        MatBadgeModule,
        MatTabsModule,
        MatSnackBarModule,
        MatSlideToggleModule
    ],
    exports: [
        MatSidenavModule,
        MatToolbarModule,
        MatIconModule,
        MatListModule,
        MatFormFieldModule,
        MatCheckboxModule,
        MatMenuModule,
        MatBadgeModule,
        MatTabsModule,
        MatSnackBarModule,
        MatSlideToggleModule
    ]
})
export class MaterialModule { }
