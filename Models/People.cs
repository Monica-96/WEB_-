using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WEB_гайд.Models
{
    public class People
    {
        // ID человекаа
        public int Person_ID { get; set; }
        // фамилия 
        public string LName { get; set; }
        // имя
        public string FName { get; set; }
        //отчество
        public string Patroymic { get; set; }
        //инфа о нем
        public string Persin_Info { get; set; }
      
    }
}