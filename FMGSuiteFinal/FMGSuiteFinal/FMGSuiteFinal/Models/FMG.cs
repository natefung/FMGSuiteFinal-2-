using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FMGSuiteFinal.Models
{

    [Table("FMG")]
    public class FMG

    {
        [Key]
        public int fmgID { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Hold Time")]
        public double fmgAvgHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Speed of Answer")]
        public double fmgAvgSpeedAnswer { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Longest Hold Time")]
        public double fmgMaxHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Abandoned Calls")]
        public int fmgAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Calls")]
        public int fmgNumberOfAcceptedCalls { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("% Abandoned")]
        public double fmgPercentAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Time To Abandon")]
        public double fmgAvgAbandon { get; set; }

        [Required(ErrorMessage = "Please enter a valid date/time")]
        [DisplayName("Current Date/Time")]
        public DateTime fmgDateTime { get; set; }
    }
}