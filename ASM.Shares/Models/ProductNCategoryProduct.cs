using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class ProductNCategoryProduct
    {
        public int ProductID { set; get; }

        public int CategoryID { set; get; }

        [ForeignKey("ProductID")]
        public MonAn Product { set; get; }

        [ForeignKey("CategoryID")]
        public Category Category { set; get; }
    }

