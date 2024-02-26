import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { map } from 'rxjs/operators'; // Import the 'map' operator
import { Make } from '../types';

@Injectable({
  providedIn: 'root'
})
export class MakeService {

  constructor(private httpClient: HttpClient) { }

  getMakes() {
    return this.httpClient.get<Make[]>('https://localhost:7004/api/makes').pipe(
      map(res => res)
    );
  }

}
