import { IProduct } from "./IProduct";
import { Injectable } from "@angular/core";

@Injectable()
export class ProductService {

    getProducts(): IProduct[] {

        return [
            {
                "Code": "Comp-001",
                "Product": "Computer",
                "Available": true,
                "Price": 35.5,
                "Rating": 4,
                "ImageUrl": "https://openclipart.org/download/265342/COMPUTADOR.svg"
            },
            {
                "Code": "Lap-002",
                "Product": "Laptop",
                "Available": true,
                "Price": 55.5,
                "Rating": 5,
                "ImageUrl": "https://openclipart.org/download/204064/Happy-Computer.svg"
            },
            {
                "Code": "Tablet-003",
                "Product": "Tablet",
                "Available": true,
                "Price": 66.5,
                "Rating": 3.5,
                "ImageUrl": "https://openclipart.org/download/178889/1370290172.svg"
            },
            {
                "Code": "TabletPen-003",
                "Product": "TabletPen",
                "Available": true,
                "Price": 77.5,
                "Rating": 3.0,
                "ImageUrl": "https://openclipart.org/download/5416/tonyk-Tablet-Pen.svg"
            }
        ];


    }

}