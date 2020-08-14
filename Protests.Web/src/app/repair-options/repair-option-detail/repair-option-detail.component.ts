import { Component, OnInit } from '@angular/core';
import { RepairOptionService } from '../repair-option.service';
import { ActivatedRoute } from '@angular/router';
import {CarService} from '../../cars/car.service';

import {Car} from 'src/app/cars/car';
import { RepairOption } from '../repair-option';

@Component({
  selector: 'app-repair-option-detail',
  templateUrl: './repair-option-detail.component.html',
  styleUrls: ['./repair-option-detail.component.scss']
})
export class RepairOptionDetailComponent implements OnInit {

  repairOption?: RepairOption;
  cars?: Car[];
  selectedCar: number;

  constructor(
    private repairOptionService: RepairOptionService,
    private activatedRoute: ActivatedRoute,
    private carService:CarService,
  ) { }

  ngOnInit(): void {
    this.loadCars();

    this.activatedRoute.paramMap.subscribe(params => {
      if(params.has('id')) {
        let id = Number(params.get('id'));
        this.loadRepairOption(id);
        
      }

  });
  }

  loadRepairOption(id: number) {
    this.repairOptionService.getRepairOption(id).subscribe(result => {
      this.repairOption = result;
    });
  }

  loadCars()
  {
    this.carService
      .getCars()
      .subscribe(result => this.cars = result)
  }

}
