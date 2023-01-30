import React, {useState} from 'react';
import PropTypes from 'prop-types';
import { Contacto } from '../models/contacto.class';


const ContactoComponent = ({contacto}) => {
   const [estado, setEstado] = useState(contacto.conectado);
    const conexion = ()=> setEstado(!estado);
    return (
        <div>
        <h1>
            Nombre : {contacto.nombre} <br></br>
            Apellido : {contacto.apellido}
        </h1>
        <h2>
            Email : {contacto.email}
        </h2>
        <h3>
            Estado : {estado?"En linea" : "No disponible"}
        </h3>
        <div>
            <button onClick={conexion}>Conectar</button>
        </div>



            
        </div>
    );
};


ContactoComponent.propTypes = {
    contacto : PropTypes.instanceOf(Contacto)

};


export default ContactoComponent;
