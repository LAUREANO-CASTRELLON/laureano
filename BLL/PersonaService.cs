using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PersonaService
    {

        private PersonaRepository personaRepository;
        public void CalcularPulsacion(Persona persona)
        {


            if (persona.Sexo.Equals("M") || persona.Sexo.Equals("m"))
            {
                persona.Pulsacion = (210 - persona.Edad) / 10;
                Console.WriteLine($"El señor {persona.Nombre} de {persona.Edad} años de edad tiene {persona.Pulsacion} pulsaciones. ");
            }
            else if (persona.Sexo.Equals("F") || persona.Sexo.Equals("f"))
            {
                persona.Pulsacion = (220 - persona.Edad) / 10;
                Console.WriteLine($"La chica {persona.Nombre} de {persona.Edad} años de edad tiene {persona.Pulsacion} pulsaciones. ");
            }
            else
            {
                Console.WriteLine($"La chica {persona.Nombre} de {persona.Edad} años de edad tiene 0 pulsaciones. ");
            }
            Console.ReadKey();

        }

        public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }

        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }

    }
}
