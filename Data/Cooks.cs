using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassyCooksWeb.Data
{
    public class Cooks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public int RID { get; set; }
        [ForeignKey("RID")]
        public Resturants resturant { get; set; }

        //foreign key
        public int DID { get; set; }
        [ForeignKey("DID")]
        public Departments department { get; set; }
    }
}
