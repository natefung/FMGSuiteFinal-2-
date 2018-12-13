using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FMGSuiteFinal.Models
{
    [Table("ENT")]
    public class ENT
    {
        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Hold Time")]
        public double entAvgHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Speed of Answer")]
        public double entAvgSpeedAnswer { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Longest Hold Time")]
        public double entMaxHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Abandoned Calls")]
        public int entAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Calls")]
        public int entNumberOfAcceptedCalls { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("% Abandoned")]
        public double entPercentAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Time To Abandon")]
        public double entAvgAbandonTime { get; set; }

        [Key]
        [Required(ErrorMessage = "Please enter a valid date/time")]
        [DisplayName("Current Date/Time")]
        public DateTime entDateTime { get; set; }
    }
}