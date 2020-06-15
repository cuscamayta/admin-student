import { Component, OnInit, Input } from '@angular/core';
import { NGXLogger } from 'ngx-logger';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  userName: string;
  currentLanguage = 'es';  

  constructor(
    public translate: TranslateService,
    private logger: NGXLogger) {
    this.translate.setDefaultLang(this.currentLanguage);
  }

  ngOnInit() {
    this.logger.debug('Init application');
    this.userName = 'Guest';
  }

  changeLanguage(e) {
    if (e.checked) {
      this.currentLanguage = 'es';
    }
    else {
      this.currentLanguage = 'en';
    }
    this.translate.setDefaultLang(this.currentLanguage);
  }

}
