import { Component, OnInit, Input, ChangeDetectorRef, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-student-card',
  templateUrl: './student-card.component.html',
  styleUrls: ['./student-card.component.scss']
})
export class StudentCardComponent implements OnInit, AfterViewInit {

  @Input() public student: any;
  @Input() public studentIndex: any;
  constructor(private cdref: ChangeDetectorRef) { }

  ngOnInit(): void {
  }

  ngAfterViewInit() {
    setTimeout(() => {
      this.cdref.detectChanges();
    }, 0);
  }
}
