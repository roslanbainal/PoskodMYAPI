using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Maklumat_Penuh", Schema = "public")]
    public class maklumat_poskod
    {
        public int Id { get; set; }
        public string Poskod { get; set; }
        public string Lokasi { get; set; }
        public string Bandar { get; set; }
        public string Negeri { get; set; }
    }
}
