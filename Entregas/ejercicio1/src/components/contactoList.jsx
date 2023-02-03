import React , {useState} from 'react';
import { Contacto } from '../models/contacto.class';
import ContactoComponent from '../pure/contacto';
import ContactoForm from '../pure/form/contactoForm';


const ContactoList = () => {
    const contacto0 = new Contacto("Eduardo", "Gordillo", "live_carr@hotmail.com", false);
    const contacto1 = new Contacto("Ivan", "Gordillo", "live@hotmail.com", false);
    const [contactos, setcontactos] = useState([contacto0, contacto1]);
    function deletedContacto(contacto){
        const index = contactos.indexOf(contacto);
        const tempArray = [...contactos];
        tempArray.splice(index, 1);
        setcontactos(tempArray);

    }
    function addContacto(contacto){
        const tempArray = [...contactos];
        tempArray.push(contacto);
        setcontactos(tempArray)
    }
    

    return (
        <div>
        <div className='col-12'>
            <div className='card'>
                <div className='card-header p-3'>
                    <h5 className='task-title'>
                        Contacto

                    </h5>
                </div>
                <div className='card-body' data-mdb-perfect-scrollbar="true" style={{ position: "relative", height: "400px" }}>
                    <table>
                        <thead>
                            <tr>
                                <th scope='col'>Nombre</th>
                                <th scope='col'>Apellido</th>
                                <th scope='col'>Email</th>
                                <th scope='col'>Estado</th>
                            </tr>
                        </thead>
                        <tbody>
                        {contactos.map((contacto, index)=>{
                            return(<ContactoComponent key={index} contacto={contacto} remove={deletedContacto}></ContactoComponent>)
                        })}
                        </tbody>
                    </table>
                </div>
                <ContactoForm add={addContacto}></ContactoForm>

            </div>

        </div>

    </div>
    );
};





export default ContactoList;
