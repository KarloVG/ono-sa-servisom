import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { ProtestListRequest } from './protest-list/protest-list.request';
import { Protest } from './protest';

@Injectable({
  providedIn: 'root'
})
export class ProtestService {

  constructor (
    private http: HttpClient
  ) { }

  getProtests(params = {}) {
    // GET req na localhost:5001/api/protests?search=abc
    return this.http.get<ProtestListRequest>(environment.apiUrl + '/protests', { params });
  }

  getProtest(id: number) {
    return this.http.get<Protest>(environment.apiUrl + '/protests/' + id);
  }

  deleteProtest(id: number) {
    return this.http.delete(environment.apiUrl + '/protests/' + id);
  }
}