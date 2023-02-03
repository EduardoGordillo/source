import React, {useState} from 'react';
import PropTypes from 'prop-types';
import { Contacto } from '../models/contacto.class';


const ContactoComponent = ({contacto, remove}) => {
    const [estado, setEstado] = useState(contacto.conectado);
    const conexion = ()=> setEstado(!estado);
    function estadoIcon() {
        if (estado) {
          return (<i  onClick={conexion} className="bi-toggle-on task-action" style={{ color: "green" }}>Conected</i>)
        } else {
          return (<i onClick={conexion} className="bi-toggle-off task-action" style={{ color: 'gray' }} >OffLine</i>)
        }
      }
    return (

        <tr className='fw-normal' style={{color: 'gray'}}>
            <th className='ms-2'><span>{contacto.nombre}</span></th>
            <td className='align-middle'><span>{contacto.apellido}</span></td>
            <td className='align-middle'><span>{contacto.email}</span></td>
            <td className='align-middle'><span>{estadoIcon()}
            <i className="bi-trash task-action" onClick={()=>remove(contacto)} style={{ color: "red" }}></i>
            </span></td>
        </tr>
       

    );
};


ContactoComponent.propTypes = {
    contacto : PropTypes.instanceOf(Contacto)

};


export default ContactoComponent;
