import { Component, OnInit } from '@angular/core';
import { Product } from 'src/products.model';


@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent implements OnInit {

  Products: Product[]=[
    {
      productId:"Samsung 70\" TV",
      productCategory:"Computers & Displays",
      productName: "UHD TV TU7000 Series",
      productPrice:"$629.99",
      productImgUrl:"https://target.scene7.com/is/image/Target/GUEST_4e327478-bf8d-4c8f-a90a-7c561597896c?qlt=85&fmt=webp&hei=1000&wid=1000",
      productQty:"3",
      productDescription:"(Sale) 70\" Smart 4K Crystal HDR"},
      
      {
        productId:"VIZIO 50\" TV",
        productCategory:"Computers & Displays",
        productName: "Smart TV - V505-J09",
        productPrice:"$299.99",
        productImgUrl:"https://target.scene7.com/is/image/Target/GUEST_e0557f9f-879e-40ac-8b9a-29b44336717e?qlt=85&fmt=webp&hei=1000&wid=1000",
        productQty:"2",
        productDescription:"(Sale) V-Series \" Class 4K HDR"}
      

  ];

  p = this.Products;

  constructor() { }

  ngOnInit(): void {
  }

}
