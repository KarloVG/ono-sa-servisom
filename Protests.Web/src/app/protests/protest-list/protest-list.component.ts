import { Component, OnInit } from '@angular/core';
import { ProtestService } from '../protest.service';

import {ProtestListRequest} from './protest-list.request';
import { Protest } from '../protest';

@Component({
  selector: 'app-protest-list',
  templateUrl: './protest-list.component.html',
  styleUrls: ['./protest-list.component.scss']
})
export class ProtestListComponent implements OnInit {

  protests: Protest[] = [];

  constructor(
    private protestService: ProtestService
  ) { }

  ngOnInit(): void {
    this.protestService.getProtests({}).subscribe(result => {
      this.protests = result.response;
    });
  }

}
