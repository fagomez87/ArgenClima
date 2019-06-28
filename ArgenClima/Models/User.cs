using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArgenClima.Models
{
    public class User
    {
        [Required]
        public string nombre;
        [Required]
        public string apellido;
        [Required]
        public string mail;

        public int Id { get; set; }
        [Required]
        public List<string> preferences;
        public bool EstaSuscripto { get; set; }

        public User(string nombre, string apellido, string mail, List<string> ciudades, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            preferences = ciudades;
            this.Id = id;


        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }


        public List<string> Preferences
        {
            get { return preferences; }
            set { preferences = new List<string>(); }
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\n\tApellido: " + apellido + "\nMail: " + mail + "\n" + "\nPreferencias: " + preferences + "\n" + "id" + Id;
        }

    }
}