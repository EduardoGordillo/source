import React, { useRef } from 'react';
import { Contacto } from '../../models/contacto.class';

const ContactoForm = ({add}) =>{
    const nombre = useRef('');
    const apellido = useRef('');
    const email = useRef('');
    function addContacto(e){
        e.preventDefault();
        const contacto = new Contacto(
            nombre.current.value,
            apellido.current.value,
            email.current.value,
            true
        );
        add(contacto);

    }
    return (
        <form onSubmit={addContacto} className="d-flex justify-content-center align-items-center mb-4">
          
        <div className='form-outline flex-fill'>
        <input ref={nombre} placeholder='Name' id='inputName' type='text' className='form-control form-control-lg' required autoFocus/>
        <input ref={apellido} placeholder='Apellido' id='inputApellido' type='text' className='form-control form-control-lg' required/>
        <input ref={email} placeholder='Email' id='inputEmail' type='text' className='form-control form-control-lg' required/>
        <button type='submit' className='btn btn-primary btn-lg ms-2'>Submit</button>
        </div>

    </form>
    );
}

export default ContactoForm;
