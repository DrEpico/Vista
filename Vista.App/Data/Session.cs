using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.App.Data
{
    public class Session
    {
        public int SessionId { get; set; }
        public int TrainerId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }

        [MaxLength(40)]
        public string? BookingReference { get; set; } //Allow nulls

        public Trainer? Trainer { get; set; }
    }
}
