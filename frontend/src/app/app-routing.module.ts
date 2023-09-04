import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FacturasComponent } from './components/facturas/facturas.component';

const routes: Routes = [
  { path: 'facturas', component: FacturasComponent},
  { path: '**', component: FacturasComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
