using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FMGSuiteFinal.Models
{
    [Table("ALP")]
    public class ALP
    {
        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Hold Time")]
        public double alpAvgHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Speed of Answer")]
        public double alpAvgSpeedAnswer { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Longest Hold Time")]
        public double alpMaxHoldTime { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Abandoned Calls")]
        public int alpAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Number of Calls")]
        public int alpNumberOfAcceptedCalls { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("% Abandoned")]
        public double alpPercentAbandoned { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        [DisplayName("Average Time To Abandon")]
        public double alpAvgAbandonTime { get; set; }

        [Key]
        [Required(ErrorMessage = "Please enter a valid date/time")]
        [DisplayName("Current Date/Time")]
        public DateTime alpDateTime { get; set; }
    }
}