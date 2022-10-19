import { Empleado } from "./Empleado.js";

export class Director extends Empleado{
    constructor(name, dni,salario){
        super(name,dni, salario);
    }
    verBonificacion(){
        const bono = 10;
        return super._verBonificacion(bono);

    }
}