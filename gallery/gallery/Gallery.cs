using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace gallery
{
    class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public virtual List<Picture> Pictures { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
