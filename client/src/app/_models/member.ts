import { Vehicle } from "./vehicle";

export interface Member {
    id: number;
    userName: string;
    vehicles: Vehicle[];
}