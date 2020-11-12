using System;
using System.Collections.Generic;

namespace Modelpage.Data
{
    public partial class Carversion
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarVersion { get; set; }
        public int OnRoadPrice { get; set; }

        public virtual Cardetails Car { get; set; }
    }
}
