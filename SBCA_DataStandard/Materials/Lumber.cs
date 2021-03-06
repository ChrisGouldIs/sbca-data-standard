﻿using SBCA_DataStandard.Enums;
using System;

namespace SBCA_DataStandard
{
    public class Lumber
    {
        public Guid Guid { get; set; }

        public string NominalThickness { get; set; }

        public string NominalWidth { get; set; }

        public double ActualThickness { get; set; }

        public double ActualWidth { get; set; }

        public LumberGrade Grade { get; set; }

        public LumberSpecies Species { get; set; }

        public string TreatmentType { get; set; }

        public GradingMethod GradingMethod { get; set; }

        public Structure Structure { get; set; }
    }
}
