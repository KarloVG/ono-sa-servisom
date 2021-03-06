import { Component, OnInit } from '@angular/core';
import { RepairOptionService } from '../repair-option.service';
import { ActivatedRoute } from '@angular/router';

import { RepairOption } from '../repair-option';

@Component({
  selector: 'app-repair-option-detail',
  templateUrl: './repair-option-detail.component.html',
  styleUrls: ['./repair-option-detail.component.scss']
})
export class RepairOptionDetailComponent implements OnInit {

  repairOption?: RepairOption;

  constructor(
    private repairOptionService: RepairOptionService,
    private activatedRoute: ActivatedRoute,
  ) { }

  ngOnInit(): void {

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

}
