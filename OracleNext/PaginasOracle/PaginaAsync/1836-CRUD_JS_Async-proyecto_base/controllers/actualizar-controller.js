import { clientServices } from "../service/client-service.js";


const form = document.querySelector('[data-form]');


const obtenerIformacion = async()=>{
    const url = new URL(window.location);
    const id = url.searchParams.get('id');

    if(id === null){
        window.location.href = '/screens/error.html';
    }
    const nombre = document.querySelector('[data-nombre]');
    const email = document.querySelector('[data-email]');
    try{
        const perfil = await clientServices.detalleCliente(id);
        if(perfil.nombre && perfil.email){
            nombre.value = perfil.nombre;
            email.value = perfil.email;
        }
        else{
            throw new Error();
            
        }
   
        
    }
    catch(err){
        console.log(err);
        window.location.href = '/screens/error.html';
    }
   
}


obtenerIformacion();
form.addEventListener('submit', async(event)=>{

    event.preventDefault();
    const url = new URL(window.location);
    const id = url.searchParams.get('id');
    const nombre = document.querySelector('[data-nombre]').value;
    const email = document.querySelector('[data-email]').value;
    await clientServices.actualizarCliente(nombre, email, id);
    window.location.href = '/screens/edicion_concluida.html'
   
});
