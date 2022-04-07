using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Models
{
    public class PredictionData
    {
        //public int crash_id { get; set; }
        public float milepoint { get; set; }
        public float pedestrian_involved { get; set; }
        public float bicyclist_involved { get; set; }
        public float motorcycle_involved { get; set; }
        public float improper_restraint { get; set; }
        public float unrestrained { get; set; }
        public float dui { get; set; }
        public float intersection_related { get; set; }
        public float wild_animal_related { get; set; }
        public float domestic_animal_related { get; set; }
        public float overturn_rollover { get; set; }
        public float commercial_motor_veh_involved { get; set; }
        public float teenage_driver_involved { get; set; }
        public float older_driver_involved { get; set; }
        public float night_dark_condition { get; set; }
        public float single_vehicle { get; set; }
        public float distracted_driving { get; set; }
        public float drowsy_driving { get; set; }
        public float roadway_departure { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                milepoint, pedestrian_involved, bicyclist_involved, motorcycle_involved, improper_restraint,
                unrestrained, dui, intersection_related, wild_animal_related, domestic_animal_related, overturn_rollover,
                commercial_motor_veh_involved, teenage_driver_involved, older_driver_involved, night_dark_condition, single_vehicle,
                distracted_driving, drowsy_driving, roadway_departure
            };
            int[] dimensions = new int[] { 1, 19 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
