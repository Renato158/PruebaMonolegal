import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Factura } from 'src/app/models/factura.models';
import { FacturaService } from 'src/app/services/factura.service';

@Component({
  selector: 'app-facturas',
  templateUrl: './facturas.component.html',
  styleUrls: ['./facturas.component.css']
})
export class FacturasComponent implements OnInit {

  facturas: Factura[] = [];

  constructor( 
    private facturaService: FacturaService,
    private route: Router) { }

  ngOnInit(): void {

    this.facturaService.getFacturas().subscribe(
      response => this.facturas = response
    )
  }

  irEditar(factura: Factura){
    if(factura.estado == "primerrecordatorio"){
      factura.estado = "segundorecordatorio";
    }else if(factura.estado == "segundorecordatorio"){
      factura.estado = "desactivado";
    }
    this.facturaService.actualizarFactura(factura).subscribe(
      response => {
        console.log(response)
        this.route.navigate(['facturas'])
      }
    )
  }


}
