using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_for_obtaining.Proxy
{
    interface IConsultationService
    {
        string GetConsultation(string question);
    }
}
