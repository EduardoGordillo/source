function validarDatosFormularioRegistroEvento(datosFormularios){
    const resultado = {
        nombre: validarNombre(datosFormularios.nombre),
        email: validarEmail(datosFormularios.email),
        telefonoMovil: validarTelefonoMovil(datosFormularios.telefonoMovil),
        edad: validarEdad(datosFormularios.edad),
        profesion: validarProfesion(datosFormularios.profesion),
        experiencia: validarExperiencia(datosFormularios.experiencia),
        
    };

    let campo;
    let esValido = true;
    for(campo in resultado){
        esValido = esValido && resultado[campo];
    }

    return {
        esValido, 
        resultado
    };
}
function validarNombre(nombre){
    return nombre.length > 3;
}
function validarEmail(email){
    const regexEmail = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return regexEmail.test(email);
}
function validarTelefonoMovil(telefonoMovil){
    const regexMovil = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/;
    return regexMovil.test(telefonoMovil);
}

function validarEdad(edad){
    return edad >= 10 &&  edad <= 50;
}
function validarProfesion(profesion){
    const profesionesDisponibles = ['estudiante', 'desarrollador', 'ingeniero', 'otro'];

    return profesionesDisponibles.indexOf(profesion) > -1;
}
function validarExperiencia(experiencia){
    return experiencia >= 1 && experiencia <= 3;
    
}
