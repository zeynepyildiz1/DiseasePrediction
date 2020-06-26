using System;
using System.Collections.Generic;
using System.Text;

namespace DiseasePredictionProject.Core.Models
{
  public  class Disease
    {
        public int Id { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public string DiseaseCauses { get; set; }
        public string? TreatmentMethod { get; set; }
        public string? Medicines { get; set; }
        public string Info { get; set; }

    }
}
