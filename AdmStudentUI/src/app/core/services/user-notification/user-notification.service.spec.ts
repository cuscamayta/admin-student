import { TestBed } from '@angular/core/testing';

import { UserNotificationService } from './user-notification.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule } from '@angular/material';

describe('UserNotificationService', () => {
  beforeEach(() => TestBed.configureTestingModule({
    imports: [MatSnackBarModule, BrowserAnimationsModule ]
  }));

  it('should be created', () => {
    const service: UserNotificationService = TestBed.inject(UserNotificationService);
    expect(service).toBeTruthy();
  });
});
