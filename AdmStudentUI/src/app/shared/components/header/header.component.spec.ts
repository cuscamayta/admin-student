import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderComponent as HeaderComponent } from './header.component';
import { MatIconModule, MatMenuModule, MatToolbarModule, MatTabsModule, MatBadgeModule } from '@angular/material';
import { RouterTestingModule } from '@angular/router/testing';
import { TranslateModule } from '@ngx-translate/core';
import { HttpClient, HttpHandler } from '@angular/common/http';

describe('HeaderBusinessComponent', () => {
  let component: HeaderComponent;
  let fixture: ComponentFixture<HeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        MatMenuModule,
        MatIconModule,
        MatToolbarModule,
        MatTabsModule,
        MatBadgeModule,
        RouterTestingModule,
        TranslateModule.forRoot()
      ],
      declarations: [ HeaderComponent ],
      providers: [HttpClient, HttpHandler]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
