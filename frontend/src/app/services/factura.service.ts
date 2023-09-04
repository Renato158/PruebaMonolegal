import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Factura } from '../models/factura.models';

@Injectable({
  providedIn: 'root'
})
export class FacturaService {

  url: string = 'https://localhost:44382/api/Factura';

  constructor( private http: HttpClient) { }

  getFacturas(): Observable<Factura[]>{
    
    return this.http.get<Factura[]>(this.url);
  }


  actualizarFactura(factura: Factura): Observable<Factura>{

    return this.http.put<Factura>(this.url, factura);
    
  }

}
