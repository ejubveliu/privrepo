import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaschenrechnerService {

  constructor(
    private http: HttpClient) { }


  getClear(): Observable<string> {
    return this.http.get<string>('/api/Calc/GetClear', { withCredentials: true });
  }

  getOper(value: string): Observable<string> {
    let params = new HttpParams().set('value', encodeURIComponent(value));
    return this.http.get<string>('/api/Calc/GetOper', { withCredentials: true, params: params });
  }

  getEqual(): Observable<string> {
    return this.http.get<string>('/api/Calc/GetEqual', { withCredentials: true });
  }
}