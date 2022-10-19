import { Cuenta } from "./Cuenta.js";


export class CuentaCorriente extends Cuenta{
    static cantidadCuentas = 0;

    constructor(cliente, numero){
        super(cliente, numero);
        CuentaCorriente.cantidadCuentas++;
    }
    retirarCuenta(valor){
       
        return super.retirarCuenta(valor, 5);
    }

}