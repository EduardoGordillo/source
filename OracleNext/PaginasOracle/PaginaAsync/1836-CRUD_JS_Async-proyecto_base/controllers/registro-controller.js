import { clientServices } from "../service/client-service.js";


const form = document.querySelector('[data-form]');
form.addEventListener('submit', async (event)=>{
    event.preventDefault();
    const nombre = document.querySelector('[data-nombre]').value;
    const correo = document.querySelector('[data-email]').value;
    try{
        await clientServices.crearCliente(nombre, correo);
    }
    catch(err){
        
    }
    window.location.href = '../screens/registro_completado.html';
    

});
