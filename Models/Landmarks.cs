using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_гайд.Models
{
    public class Landmarks
    {
        // ID покупки
        public int Landmark_ID { get; set; }
        // Название
        public string Name { get; set; }
        // адрес
        public int Address_ID { get; set; }
        // 
        public int NET_ID { get; set; }
        // 
        public int Creator_ID { get; set; }
        // 
        public int Year { get; set; }
        //
        public string Owner_ID { get; set; }
        // 
        public int Type_ID { get; set; }
        //
        public string Entry_ID { get; set; }
        // 
        public int Description { get; set; }
        
    }
}