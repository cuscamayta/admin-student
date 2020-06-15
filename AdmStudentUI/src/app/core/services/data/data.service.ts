import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NGXLogger } from 'ngx-logger';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  env = environment;
  context: string;

  constructor(
    private http: HttpClient,
    private logger: NGXLogger) {
  }

  get(url: string) {
    this.logger.debug('DataService get url', url);
    return this.executeAndHandleRequest(url, () => {
      const headers = new HttpHeaders({
        'Content-Type': 'application/json'
      });
      const options: any = {
        headers,
        observe: 'response'
      };

      return this.http.get<any>(`${this.env.urlApi}/${url}`, options);
    });
  }

  post(url, bodyData) {
    this.logger.debug('post url:', `${this.env.urlApi}/${url}`, ' ,payload:', JSON.stringify(bodyData));
    return this.executeAndHandleRequest(url, () => {
      const headers = new HttpHeaders({
        'Content-Type': 'application/json, text/plain',
        Accept: 'text/html, application/xhtml+xml, */*',
      });

      const requestOptions: any = {
        headers,
        observe: 'response',
        responseType: 'text'
      };
      return this.http.post<any>(`${this.env.urlApi}/${url}`, bodyData, requestOptions);
    });
  }

  delete(url: string, source: string) {
    this.logger.debug('delete url:', `${this.env.urlApi}/${url}`, ' ,source:', source);
    return this.executeAndHandleRequest(url, () => {
      const headers = new HttpHeaders({
        'Content-Type': 'application/json'
      });
      const options: any = {
        headers,
        observe: 'response'
      };
      return this.http.delete<any>(`${this.env.urlApi}/${url}`, options);
    });
  }

  executeAndHandleRequest(url, request): Observable<any> {
    try {
      return request();
    } catch (ex) {
      this.logger.error('url:', `${this.env.urlApi}/${url}`, ' ,exception', ex);
    }
  }

}
