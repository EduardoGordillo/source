import {Cliente} from "./Cliente.js";
import {Cuenta} from "./Cuenta.js";
import {CuentaAhorro} from "./CuentaAhorro.js";
import {CuentaCorriente} from "./CuentaCorriente.js";


const Jose = new Cliente('José', '1641');
const cuentaJose = new CuentaCorriente(Jose, CuentaCorriente.cantidadCuentas+1);
console.log(cuentaJose, cuentaJose.cliente);

const Daniel = new Cliente('Daniel', '1845');
const cuentaDaniel = new CuentaCorriente(Daniel, CuentaCorriente.cantidadCuentas+1);
console.log(cuentaDaniel, cuentaDaniel.cliente)

const Ivan = new Cliente('Ivan','1216');
const cuentaIvan  = new CuentaAhorro(Ivan, CuentaAhorro.cantidadCuentas+1, 1000);
console.log(cuentaIvan, cuentaIvan.cliente)
cuentaIvan.depositoCuenta(1000);
cuentaIvan.retirarCuenta(800);
cuentaDaniel.depositoCuenta(1000);
cuentaDaniel.retirarCuenta(800);

console.log(cuentaIvan, cuentaIvan.consultaSaldo());
console.log(cuentaDaniel, cuentaDaniel.consultaSaldo());
