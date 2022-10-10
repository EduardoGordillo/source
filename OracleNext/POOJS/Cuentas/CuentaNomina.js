import {Cuenta} from './Cuenta.js';
export class CuentaNomina extends Cuenta{
    static cantidadCuentas = 0;
    constructor(cliente, numero){
        super(cliente, numero);
        CuentaNomina.cantidadCuentas++;

    }
    retirarCuenta(valor){
        super.retirarCuenta(valor, 1);

    }

}