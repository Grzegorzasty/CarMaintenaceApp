import { Photo } from "./photo";

export interface RepairDetails{
    id: number,
    date: Date,
    laborPrice: number,
    partsPrice: number,
    checkBoxValues: string,
    keyWords: string,
    description: string,
    workshopName: string,
    photos: Photo[]
}