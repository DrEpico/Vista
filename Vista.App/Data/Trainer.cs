using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.App.Data
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(50)]
        public string? Location { get; set; } //The question mark allow nulls
        public List<TrainerCategory>? TrainerCategories { get; set; }
        public List<Session>? Sessions { get; set; }
    }
}
