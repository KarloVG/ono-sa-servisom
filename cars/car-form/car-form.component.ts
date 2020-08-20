import { Component, OnInit } from '@angular/core';
import { CarService } from '../../cars/car.service';

import { Car} from '../../cars/car';
import { Router } from '@angular/router';
import { LoadingService } from '../../shared/loading/loading.service';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-cart-form',
  templateUrl: './car-form.component.html',
  styleUrls: ['./car-form.component.scss']
})
export class CarFormComponent implements OnInit {

  cars?: Car[];

  constructor(
    private carService: CarService,
    private loadingService: LoadingService,
    private router: Router,
    private toastr: ToastrService
  ) { }

  ngOnInit(): void {
    this.loadCars();
  }

  onSubmit() {
    this.loadingService.show();
    this.carService
      .postCar(this.car)
      .subscribe(result => {
        this.loadingService.hide();
        this.toastr.success('Success');
        let carId = result.id;
        this.router.navigate(['cars/' + carId]);
      });
  }

  loadCars() {
    this.carService
      .getCars()
      .subscribe(result => this.cars = result)
  }

}
