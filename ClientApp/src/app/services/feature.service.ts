import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';  
import { map } from 'rxjs/operators'; // Import the 'map' operator
import { Feature } from '../types';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {
  constructor(private httpClient: HttpClient) { }
  getFeatures() {
    return this.httpClient.get<Feature[]>('https://localhost:7004/api/features').pipe(
      map(res => res)
    );
  }
}
