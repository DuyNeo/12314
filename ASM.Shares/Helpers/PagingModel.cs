using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PagingModel
    {
        public int CurrentPage { get; set; }
        public int CountPage { get; set; }
        public Func<int?, string> generateURL { get; set; }
    }

