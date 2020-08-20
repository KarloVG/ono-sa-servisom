import { Component, OnInit } from '@angular/core';
import { RepairOptionService } from '../repair-option.service';
import { ActivatedRoute } from '@angular/router';

import { RepairOption } from '../repair-option';

@Component({
  selector: 'app-repair-option-form',
  templateUrl: './repair-option-form.html',
  styleUrls: ['./repair-option-form.scss']
})
export class RepairOptionFormComponent implements OnInit {

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
