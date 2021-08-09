import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  constructor(private http:HttpClient) {   }
  
  getMakes() {
    return this.http.get<any>('makes').pipe(map(res => res));
  }

  getFeatures() {
    return this.http.get<any>('features').pipe(map(res => res));
  }
}
