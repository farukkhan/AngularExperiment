import { Component, OnInit } from "@angular/core";
import { IProduct } from "./IProduct";

@Component({
    selector: 'pm-productlist',
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css'],
})

export class ProductListComponent implements OnInit {
    ngOnInit(): void {
        console.log('Form inside OnInit....');
    }
    pageTitle: string = "Product List";
    imageWidth: number = 50;
    imageMargin: number = 2;
    showImage: boolean = true;
    filterList: string = "Comp";
    products: IProduct[]= [
        {
            "Code": "Comp-001",
            "Product": "Computer",
            "Available": true,
            "Price" : 35.5,
            "Rating": 4,
            "ImageUrl": "https://openclipart.org/download/265342/COMPUTADOR.svg"
        },
        {
            "Code": "Lap-002",
            "Product": "Laptop",
            "Available": true,
            "Price": 55.5,
            "Rating": 4.5,
            "ImageUrl": "https://openclipart.org/download/204064/Happy-Computer.svg"
        }
    ];
    toggleImage(): void {
        this.showImage = !this.showImage;
    }

}