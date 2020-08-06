import { Protest } from '../protest';

export interface ProtestListRequest {
    success: boolean;
    response: Protest[];
}