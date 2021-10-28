using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Models
{
    public class Bicycle
    {
        public int BicycleId {get;set;}
        [Required(ErrorMessage = "Укажите название велосипеда!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Укажите цвет велосипеда!")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Укажите тип велосипеда!")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Укажите диаметр колеса!")]
        public int WheelDiametr { get; set; }
        [Required(ErrorMessage = "Укажите размер рамы!")]
        public int FrameSize { get; set; }
        [Required(ErrorMessage = "Укажите материал рамы!")]
        public string FrameMaterial { get; set; }
        [Required(ErrorMessage = "Укажите стоимость велосипеда!")]
        public int Price { get; set; }
        
    }
}
