import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { RepairOption } from './repair-option';


@Injectable({
  providedIn: 'root'
})
export class RepairOptionService {

  constructor (
    private http: HttpClient
  ) { }

  getRepairOptions(params = {}) {
    // GET req na localhost:5001/api/protests?search=abc
    return this.http.get<RepairOption[]>(environment.apiUrl + '/repair_options', { params });
  }

  getRepairOption(id: number) {
    return this.http.get<RepairOption>(environment.apiUrl + '/repair_options/' + id);
  }

  deleteRepairOption(id: number) {
    return this.http.delete(environment.apiUrl + '/repair_options/' + id);
  }
}