import { FeatureService } from './../../services/feature.service';
import { Feature, Model, Make } from './../../types'; 
import { MakeService } from './../../services/make.service'; 
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  makes!: Make[];
  models!: Model[];
  features!: Feature[]; 
  vehicle:any = {};

  constructor(private MakeService: MakeService,
    private FeatureService: FeatureService
    ) {

  }


  ngOnInit(): void { 
    this.MakeService.getMakes().subscribe(makes => { 
      this.makes = makes;  
    });

    this.FeatureService.getFeatures().subscribe(features => { 
      this.features = features;  
    });
  }

  onMakeChange(){  
    let selectedMake = this.makes.find(m => m.id == this.vehicle.make);  
    this.models = selectedMake?.models ?? []; 
  }

}
