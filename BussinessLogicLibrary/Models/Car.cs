using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLibrary
{
    public class Car : IVehicle
    {
      
        public int Size { get; set; } = 4;
        [Key]
        public string Registration { get; set; }
        public DateTime? StartTime { get; set; }

        public int Parkingspot { get; set; }
    }
}
