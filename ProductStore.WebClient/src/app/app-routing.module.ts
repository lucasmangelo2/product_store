import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoryComponent } from './product-store/views/category/category.component';
import { ProductComponent } from './product-store/views/product/product.component';
import { HomeComponent } from './product-store/views/home/home.component';


export const routes: Routes = [
  {component: HomeComponent, path: '', data: {title: 'Home'}},
  {component: CategoryComponent, path: 'categories', data: {title: 'Categoria'}},
  {component: ProductComponent, path: 'product', data: {title: 'Produtos'}},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
