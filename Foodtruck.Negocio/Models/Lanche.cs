using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    public class Lanche : Produto
    {
        
        public override string Descrever()
        {
            return String.Format($"{this.Id} - {this.Nome} - {this.Valor}");
        }
    }
}
