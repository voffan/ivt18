using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace carton
{
    public class ProductOperation
    {
        public Product product;
        public int amount;
        public Department source;
        public Department destination;
        public string date; //TO-DO string

        public ProductionLine production_line;
        public Storage storage;
        public Employee employee;
    }
}
