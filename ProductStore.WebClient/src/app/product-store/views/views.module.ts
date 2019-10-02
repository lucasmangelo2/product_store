import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryComponent } from './category/category.component';
import { ProductComponent } from './product/product.component';
import { ProductFormComponent } from './product/product-form/product-form.component';
import { ProductViewComponent } from './product/product-view/product-view.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    CategoryComponent, 
    ProductComponent, 
    ProductFormComponent, 
    ProductViewComponent,
    HomeComponent
  ],
  exports: [
    CategoryComponent, 
    ProductComponent, 
    ProductFormComponent, 
    ProductViewComponent,
    HomeComponent
  ],
  imports: [
    CommonModule
  ],
})
export class ViewsModule { }
