using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_for_obtaining.Proxy
{
    class ConsultationProxy : IConsultationService
    {
        private RealConsultationService _realService = new RealConsultationService();

        public string GetConsultation(string question)
        {
            List<string> allowedQuestions = new List<string> { "Які звернення НБУ не розглядає", "За скільки часу отримаю відповідь", "Як оскаржити дії чи бездіяльність Національного банку" };
            if (!allowedQuestions.Contains(question))
            {
                return "Дане питання не може бути оброблене";
            }

            return _realService.GetConsultation(question);
        }
    }
}
