import { Component, OnInit } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { UserNotificationService, UserNotificationType } from 'src/app/core/services/user-notification/user-notification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.scss']
})
export class StudentListComponent implements OnInit {
  students: any;

  constructor(
    private studentService: StudentService,
    private userNotification: UserNotificationService,
    private translate: TranslateService) { }

  ngOnInit(): void {
    this.fetchStudents();
  }

  fetchStudents() {
    this.handleResponse(this.studentService.fetchStudents(), (response) => {
      this.students = response.body.Data;
    });
  }


  private handleResponse(request, afterRequest) {
    request.subscribe(
      response => {
        if (response) {
          if (response.status === 200 && response.body) {
            afterRequest(response);
          } else {
            this.showNotification('validation.messages.badGetInformation', UserNotificationType.Warning);
          }
        } else {
          this.showNotification('validation.messages.badGetInformation', UserNotificationType.Warning);
        }
      }, error => {
        this.showNotification('validation.messages.badGetInformation', UserNotificationType.Error);
      });
  }

  showNotification(message, typeNotification) {
    this.translate.get(message).subscribe((text: string) => {
      this.userNotification.showMessage(text, typeNotification);
    });
  }

}
