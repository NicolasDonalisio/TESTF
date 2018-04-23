using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFDLT.Models
{
    public class Persona
    {
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
    }
}