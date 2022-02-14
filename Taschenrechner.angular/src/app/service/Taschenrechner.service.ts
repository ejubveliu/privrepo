import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaschenrechnerService {

  constructor(
    private http: HttpClient) { }

    
  getClear(): Observable<number> {
    return this.http.get<number>('/api/Calc/GetClear',{withCredentials:true});
  }

  getOper(): Observable<string> {
    return this.http.get<string>('/api/Calc/GetOper',{withCredentials:true});
  }

  getEqual(): Observable<number> {
    return this.http.get<number>('/api/Calc/GetEqual',{withCredentials:true});
  }
}