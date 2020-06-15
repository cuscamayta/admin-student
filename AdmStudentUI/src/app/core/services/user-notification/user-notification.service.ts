import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material';

export enum UserNotificationType {
  Error = 'error-snackbar',
  Warning = 'warn-snackbar',
  Info = 'inf-snackbar',
  Sucess = 'succ-snackbar'
}

@Injectable({
  providedIn: 'root'
})
export class UserNotificationService {

  constructor(private notification: MatSnackBar) { }

  public showMessage(errorText, errorType: UserNotificationType = UserNotificationType.Sucess) {
    this.notification.open(errorText, 'Dismiss', {
      duration: 3000,
      verticalPosition: 'bottom',
      panelClass: errorType
    });
  }
}
