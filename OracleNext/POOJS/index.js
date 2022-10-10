import {Cliente} from "./Cliente.js";
import {CuentaNomina} from "./Cuentas/CuentaNomina.js";
import {CuentaAhorro} from "./Cuentas/CuentaAhorro.js";
import {CuentaCorriente} from "./Cuentas/CuentaCorriente.js";
import {Director} from "./Empleados/Director.js"
import { SistemaAutenticacion } from "./SistemaAutenticacion.js";

const Jose = new Cliente('José', '1641');
const cuentaJose = new CuentaCorriente(Jose, CuentaCorriente.cantidadCuentas+1);
console.log(cuentaJose, cuentaJose.cliente);

const Daniel = new Cliente('Daniel', '1845');
const cuentaDaniel = new CuentaCorriente(Daniel, CuentaCorriente.cantidadCuentas+1);
console.log(cuentaDaniel, cuentaDaniel.cliente)

const Ivan = new Cliente('Ivan','1216');
const cuentaIvan  = new CuentaAhorro(Ivan, CuentaAhorro.cantidadCuentas+1, 1000);
console.log(cuentaIvan, cuentaIvan.cliente);

const Edd = new Cliente('Eduardo', '0100');
const cuentaEdd = new CuentaNomina(Edd, CuentaNomina.cantidadCuentas+1)
console.log(cuentaEdd, cuentaEdd.cliente);

const EddDirector = new Director('Eduardo', '0100', 100000);

console.log(SistemaAutenticacion.login(Ivan,''))
console.log(SistemaAutenticacion.login(EddDirector,''));



