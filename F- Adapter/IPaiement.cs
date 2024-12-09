using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F__Adapter
{
    internal interface IPaiement
    {
        void Payer(decimal montant);
    }
}
