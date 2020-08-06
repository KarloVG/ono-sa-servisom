import { Component, OnInit } from '@angular/core';
import { RepairOptionService } from '../repair-option.service';
import { RepairOption } from '../repair-option';

@Component({
  selector: 'app-repair-option-list',
  templateUrl: './repair-option-list.component.html',
  styleUrls: ['./repair-option-list.component.scss']
})
export class RepairOptionListComponent implements OnInit {

  /* ovdje se nalaze podaci kada dodu sa servera, koji su popunjeni unutar ngOnInit() */
  repairOptions: RepairOption[] = [];

  constructor(
    private repairOptionService: RepairOptionService
  ) { }

  ngOnInit(): void {
    this.repairOptionService
      .getRepairOptions()
      .subscribe(result => {
        this.repairOptions = result;
      })
  }

}
