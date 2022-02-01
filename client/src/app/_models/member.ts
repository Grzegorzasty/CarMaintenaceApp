import { Vehicle } from "./Vehicle";

export interface Member {
    id: number;
    userName: string;
    vehicles: Vehicle[];
}