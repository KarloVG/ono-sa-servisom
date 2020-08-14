import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Car } from './car';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  constructor(
    private http: HttpClient
  ) { }

  getCars(params = {}) {
    return this.http.get<Car[]>(environment.apiUrl + '/cars', { params });
  }
}
