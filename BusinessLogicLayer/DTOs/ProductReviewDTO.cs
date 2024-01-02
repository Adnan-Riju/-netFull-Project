using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class ProductReviewDTO
    {
        public int Id { get; set; }
        
        public string ProductName { get; set; }
       
        public string ProductDescription { get; set; }
 
        public int ProductRating { get; set; }

        public string ReviewedBy { get; set; }

    }
}
