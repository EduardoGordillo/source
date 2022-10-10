export class Cliente  {

    #clave;
    
    constructor(nombreCliente,dniCliente){
    this.nombre= nombreCliente;
    this.dni = dniCliente;
    this.#clave = '';
   
        }
    asignarClave(clave){
        this.#clave =clave;
    }
    autenticable(clave){
        return true;
    }


    }