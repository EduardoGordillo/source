import {Cliente} from './Cliente.js';
var exitoso = false;
export class Cuenta {
    
    #cliente;
    numero;
    #saldo;
    

    set cliente(ref) { 
        if(ref instanceof Cliente){
           this.#cliente =  ref;
        }
     }
    get cliente(){ return this.#cliente; }

    constructor(cliente, numero, saldo){

        this.cliente = cliente || null;
        this.numero = numero;
        this.#saldo = saldo || 0;
        
    }
    depositoCuenta(valor)
    {
        if(valor < 0){
            console.log('Numero invalido');
            exitoso = false;
        }
        else{
            exitoso = true;
            return this.#saldo += valor;
           
        }
    }
    retirarCuenta(valor, comision){
        if(comision){
            valor = valor * (1+comision/100)
            console.log(valor)
        }
        
        
        
        if(this.#saldo < valor){
            console.log('Fondos insuficientes')
        }
        else{
           
            return this.#saldo -= valor;
           
        }
    }
    consultaSaldo(){
        return this.#saldo;
    }
    transferirOtraCuenta(valor, cuentaDestino){
        this.retirarCuenta(valor);
        if(exitoso){
        cuentaDestino.depositoCuenta(valor)}
        else{
            console.log('Retiro no Valido')
        }
    }

}