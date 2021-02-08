using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_do_Tio_Bill.Class
{
   public class ItensDoPedido
    {
        public int IdClient { get; set; }
        List<Quentinha> q = new List<Quentinha>();

        public void addQuentinhaList(Quentinha qe)
        {
            q.Add(qe);
        }


    }
}
