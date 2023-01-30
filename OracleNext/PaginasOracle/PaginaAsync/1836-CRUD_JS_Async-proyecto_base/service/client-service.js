const listaClientes = async() => {
   try{
    const perfiles = await fetch('http://localhost:3000/perfil')
    if(perfiles){
        return perfiles.json();
    }
    else{
        throw new Error();
    }
   }
   catch(err){
    console.error(err);
    window.location.href = '/screens/error.html';
   }
};

const crearCliente = (nombre, email)=>{
    return fetch('http://localhost:3000/perfil', {
        method: 'POST',
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({nombre, email, id : uuid.v4()})

    })
}
const eliminarCliente = (id)=>{
    return fetch('http://localhost:3000/perfil/'+id,{
        method: 'DELETE'
    })
}
const detalleCliente = (id)=> {
    return fetch('http://localhost:3000/perfil/'+id).then(res=>res.json())
}

const actualizarCliente = (nombre, email, id)=>{
    return fetch('http://localhost:3000/perfil/'+id, {
        method: 'PUT',
        headers:{
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            nombre,
            email
        })}).then(res=>console.log(res)).catch(err=>console.log(err));
    
}

export const clientServices = {
    listaClientes,
    crearCliente,
    eliminarCliente,
    detalleCliente,
    actualizarCliente
}
