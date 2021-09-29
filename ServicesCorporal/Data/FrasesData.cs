using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCorporal.Data
{
    public class FrasesData
    {
        static Dictionary<string, string> Frases = new Dictionary<string, string>
        {
            {"1", "Cuando pierdas, no pierdas la lección "}, 
            {"2", "No busques los errores, busca un remedio"}, 
            {"3", "La vida es una aventura, atrévete"}, 
            {"5", "Tu actitud, no tu aptitud, determinará tu altitud"}, 
            {"6", "Tienes que hacer las cosas que crees que no puedes hacer"}, 
            {"7", "Si te caíste ayer, levántate hoy"}, 
            {"8", "Siempre parece imposible... hasta que se hace"}, 
            {"9", "Si no pierdes, no puedes disfrutar de las victorias"}, 
            {"10", "No dejes que el miedo se interponga en tu camino"}, 
            {"11", "No cuentes los días, haz que los días cuenten "}, 
            {"12", "El mejor momento del día es ahora"}, 
            {"13", "Si la oportunidad no llama, construye una puerta"}, 
            {"14", "Deja que cada hombre ejerza el arte que domina"}, 
            {"15", "El valor de una idea radica en su uso"}, 
            {"16", "Piensa, sueña, cree y atrévete "}, 
            {"17", "Con autodisciplina casi todo es posible"}, 
            {"18", "Asegúrate de que colocas tus pies en el lugar correcto, y luego mantente firme"}, 
            {"19", "Transforma tus heridas en sabiduría "}, 
            {"20", "La innovación distingue al líder del seguidor"}, 
            {"21", "Si puedes soñarlo, puedes hacerlo"}, 
            {"22", "El secreto para salir adelante es comenzar"}, 
            {"23", "La vida es como montar en bicicleta. para mantener el equilibrio tienes que avanzar"}, 
            {"24", "Sé valiente. Toma riesgos. Nada puede sustituir la experiencia"}, 
            {"25", "El conocimiento es poder"}, 
            {"26", "Solo puede ser feliz siempre el que sabe ser feliz con todo"}, 
            {"27", "No pares cuando estés cansado. Para cuando hayas terminado"}, 
            {"28", "Cree que puedes y casi lo habrás logrado"}, 
            {"29", "Hoy eres un lector y mañana serás un líder"}, 
        };

        public static string GetShortDescription(string code)
        {
            string result;
            if (!Frases.TryGetValue(code, out result))
                return null;

            return result;
        }

    }
}
