using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDefault.Models
{
    public class PasMacka
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public string Color { get; set; }
        public int Godina { get; set; }
        public int Mesec { get; set; }
        public int Dan { get; set; }
        
    }

    public class GradoviModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}