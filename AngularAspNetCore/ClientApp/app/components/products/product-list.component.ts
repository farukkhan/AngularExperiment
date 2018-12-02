import { Component } from "@angular/core";

@Component({
    selector: 'pm-productlist',
    templateUrl:'./product-list.component.html'
})

export class ProductListComponent {

    pageTitle: string = "Product List";
    imageWidth: number = 50;
    imageMargin: number = 2;
    showImage: boolean = true;
    filterList: string = "Comp";
    products: any[]= [
        {
            "ImageUrl":"https://openclipart.org/download/265342/COMPUTADOR.svg",
            "Code":"Comp001",
            "Product": "Computer",
            "Available": "True",
            "Price" : "35.5",
            "Rating": "4.2"
        },
        {
            "ImageUrl": "https://openclipart.org/download/204064/Happy-Computer.svg",
            "Code": "Lap002",
            "Product": "Laptop",
            "Available": "True",
            "Price": "55.5",
            "Rating": "4.5"
        }
        
    ];

    toggleImage(): void {
        this.showImage = !this.showImage;
    }

}