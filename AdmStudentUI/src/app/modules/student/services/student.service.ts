import { Injectable } from '@angular/core';
import { DataService } from 'src/app/core/services/data/data.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  entityName = 'students';
  constructor(private dataService: DataService) { }

  fetchStudents(): Observable<any> {
    return this.dataService.get(this.entityName);
  }

  fetchStudentsByName(studentName: string): Observable<any> {
    return this.dataService.get(`${this.entityName}/${studentName}`);
  }
}
