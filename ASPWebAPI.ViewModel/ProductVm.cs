using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebAPI.ViewModel
{
    public class ProductVm: ItemVm
    {
        public IEnumerable<ProductFamilyVm> Families { get; set; }

        public ProductVm(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            Families = new List<ProductFamilyVm> { new ProductFamilyVm() { Codigo = "WIP", Nombre = "Prod. Family" } };
        }
    }
}
