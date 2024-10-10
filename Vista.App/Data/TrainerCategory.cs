using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class TrainerCategory
    {
        //Has a composite (compund) key that will be defined TrainersDbConext

        [Required]
        public int TrainerId { get; set; }
        [MaxLength(15)] public required string CategoryCode { get; set; }

        //Placeholder a navigation property to Trainer (one side of one-to-many)
        // See TrainersDbConext for Foreign Key (Fluent API) definition
        // Placeholder for a navigation property to Category (one side of one-to-many)
    }
}
