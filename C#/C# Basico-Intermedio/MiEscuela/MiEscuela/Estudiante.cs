using System;
using System.Collections.Generic;
using System.Text;

namespace MiEscuela
{
    class Estudiante
    {
        public bool Estatus { get; private set; }

        
        #region Atributos
        private int id;
        private string matricula;
        string nombre;
        string gradoGrupo;
        bool estatus;

        #endregion

        #region Propiedades
        #endregion
        
        #region Metodos

        public string Registrar()
        {
            //registro en la BD
            string resp = "Alumno Registrado ";
            return resp;


        }

        public string DarDeBaja()
        {
            this.Estatus = false;
            //editar en BD el registro, agregar motivo
            string respuesta = "Alumno dado de baja";
            return respuesta;

        
        }


        public string DarDeBaja(string motivo = "")
        {
            this.Estatus = false;
            //editar en BD el registro
            // editar registro en la BD()
            string respuesta = "";
            if (motivo != "")
            { 
                respuesta = "Alumno dado de baja. Motivo" + motivo;
            }
            else
            {
                respuesta = "Alumno dado de baja";
            }
            return respuesta;


        }
        public void DarDeBaja(string cveUsuario, string pwd,  string motivo  )
        {
            this.Estatus = false;
            //consultar que el usuario cuente con los permisos necesesarios
            //VerificarUsuario(cveUsuario, pwd)
            //si el usuario es verificado .
            //eliminar el registro del estudiante 
            //guardar el movimiento en un log
           
           
        }
        #endregion

        #region Constructor
        public Estudiante(string nombre, string gradoGrupo )
        {
           this.nombre = nombre;
           string GradoGrupo = gradoGrupo;

        }

        public Estudiante(bool estatus)
        {
            Estatus = estatus;
            this.nombre = "";



        }
        #endregion 
    }
}
