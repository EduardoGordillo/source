import { Cliente} from './Cliente.js';
import { Cuenta } from './Cuenta.js';
export class CuentaAhorro extends Cuenta {

    static cantidadCuentas = 0;

    constructor(cliente,numero, saldo){
        super(cliente,numero, saldo);
        CuentaAhorro.cantidadCuentas++;
    }
    retirarCuenta(valor){
        
        return super.retirarCuenta(valor, 2);
        

    }


}