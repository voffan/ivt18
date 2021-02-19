using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Data.Entity.Spatial;

namespace carton
{
    public class ProductPL
    {
    	[Key]
    	public int Id { get; set; }
    	public int ProductOperationId { get; set; }
    	[ForeignKey("ProductOperationId")]
    	public ProductOperation ProductOperation { get; set; }

    	public int ProductionLineId { get; set; }
    	[ForeignKey("ProductionLineId")]
    	public ProductionLine ProductionLine { get; set; }
    }
}