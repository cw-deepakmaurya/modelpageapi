using System;
using System.Collections.Generic;

namespace Modelpage.Data
{
    public partial class Cardetails
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string CarName { get; set; }
        public int AveragePrice { get; set; }
        public string ImgUrl { get; set; }
    }
}
