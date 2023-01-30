import React from 'react';
import { Contacto } from '../models/contacto.class';
import ContactoComponent from '../pure/contacto';


const ContactoList = () => {
    const contacto = new Contacto("Eduardo", "Gordillo", "live_carr@hotmail.com", false);

    return (
        <div>
            <ContactoComponent contacto={contacto}></ContactoComponent>
        </div>
    );
};





export default ContactoList;
