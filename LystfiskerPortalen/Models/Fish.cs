using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LystfiskerPortalen.Models
{
    public class Fish
    {
        //Properties
        public int FishId { get; set; }
        [Required(ErrorMessage = "Udfyld hvad for en fisk du har fanget")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage ="Udfyld fiskens længde")]
        public int Length { get; set; }
        [Required(ErrorMessage ="Udfyld fiskens vægt")]
        public double Weight { get; set; }

        //Constructor
        public Fish(string name, int length, double weight)
        {
            Name = name;
            Length = length;
            Weight = weight;
        }
        public Fish()
        {
            
        }




    }
}
