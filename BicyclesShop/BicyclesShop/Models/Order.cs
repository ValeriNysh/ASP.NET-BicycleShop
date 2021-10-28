using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Введите имя пользователя!")]
        public string User { get; set; }
        [Required(ErrorMessage = "Введите контактный номер!")]
        public string ContactPhone {get; set; }
        [Required(ErrorMessage = "Введите адрес!")]
        public string Address { get; set; }
        public int? BicycleId { get; set; }
        public Bicycle Bicycle { get; set; }
    }
}
