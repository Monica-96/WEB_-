using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WEB_гайд.Models
{
    public class TOURGUIDE_context: DbContext
    {
        //помогают получать из БД набор данных определенного 
        //типа (например, набор объектов People).
        public DbSet<People> People { get; set; }
        public DbSet<Landmarks> Landmarks { get; set; }
    }
}