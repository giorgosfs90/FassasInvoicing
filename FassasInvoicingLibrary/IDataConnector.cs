using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FassasInvoicingLibrary
{
    public interface IDataConnector
    {
        Eteria CreatePelatis(Eteria e1);
        Invoice CreateInvoice(Invoice i1);
        List<Eteria> GetEteries();
    }
}
