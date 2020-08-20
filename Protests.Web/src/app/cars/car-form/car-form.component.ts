import { Component, OnInit } from '@angular/core';
import { CarService } from '../../cars/car.service';

import { Car} from '../../cars/car';
import { Router } from '@angular/router';


@Component({
  selector: 'app-cart-form',
  templateUrl: './car-form.component.html',
  styleUrls: ['./car-form.component.scss']
})
export class CarFormComponent implements OnInit {

  cars?: Car[];

  constructor(
    private carService: CarService,
    private router: Router,
  ) { }

  ngOnInit(): void {
    this.loadCars();
  }

  loadCars() {
    this.carService
      .getCars()
      .subscribe(result => this.cars = result);
  }
}
