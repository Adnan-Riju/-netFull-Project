using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class LikeDTO
    {
        public int LikeID { get; set; }
    
        public string UserName { get; set; }
        
        public int BlogID { get; set; }

    }
}