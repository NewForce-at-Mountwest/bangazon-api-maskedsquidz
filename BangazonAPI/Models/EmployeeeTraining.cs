using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonAPI.Models
{
    public class EmployeeeTraining
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int TrainingProgramId { get; set; }
}
}
