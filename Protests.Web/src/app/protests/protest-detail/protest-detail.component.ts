import { Component, OnInit } from '@angular/core';
import { Protest } from '../protest';
import { ProtestService } from '../protest.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-protest-detail',
  templateUrl: './protest-detail.component.html',
  styleUrls: ['./protest-detail.component.scss']
})
export class ProtestDetailComponent implements OnInit {

  protest?: Protest;
  id: number = 0;

  constructor(
    private activatedRoute: ActivatedRoute,
    private protestService: ProtestService
  ) { }



  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(params => {
        // this.id = +params.get('id') as number;
        this.id = 1;
        this.loadProtest();
    });
  }

  loadProtest() {
    this.protestService.getProtest(this.id).subscribe(result => {
      this.protest = result;
    });
  }

}
