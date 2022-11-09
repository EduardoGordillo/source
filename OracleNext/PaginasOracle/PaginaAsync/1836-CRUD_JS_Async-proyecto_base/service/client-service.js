const crearNuevaLinea = (nombre, correo) => {
    const linea = document.createElement('tr')
    const content = `
    <td class="td" data-td>${nombre}</td>
    <td>${correo}</td>
    <td>
      <ul class="table__button-control">
        <li>
          <a
            href="../screens/editar_cliente.html"
            class="simple-button simple-button--edit"
            >Editar</a
          >
        </li>
        <li>
          <button
            class="simple-button simple-button--delete"
            type="button"
          >
            Eliminar
          </button>
        </li>
      </ul>
    </td>`;
    linea.innerHTML = content;
    return linea
}

const listaClientes = () => {
    const promise = new Promise((resolve, reject) => {
        const http = new XMLHttpRequest();
        http.open('GET', 'http://localhost:3000/perfil')
        http.send();
        http.onload = () => {
            const response = JSON.parse(http.response);
            if(http.status >= 400){
                reject(response);
            }else{
                resolve(response);
            };
        };
    });
    return promise
}
const table = document.querySelector('[data-table]');

listaClientes().then((perfiles)=>{
perfiles.forEach(perfil => {
    const linea = crearNuevaLinea(perfil.nombre, perfil.email);
    table.appendChild(linea);
})
}).catch((error)=>{
    alert('ocurrio un error')
});;