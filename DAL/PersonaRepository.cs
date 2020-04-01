using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";

            public void Guardar (Persona persona)
            {

            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($" {persona.Identificacion} ; {persona.Nombre} ; {persona.Sexo} ; {persona.Edad} ; {persona.Pulsacion} " ) ;
            escritor.Close();
            file.Close();

            }
    }
}
