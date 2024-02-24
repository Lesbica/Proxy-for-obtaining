﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_for_obtaining.Proxy
{
    class RealConsultationService : IConsultationService
    {
        private Dictionary<string, string> _responses = new Dictionary<string, string>()
    {
        { "Які звернення НБУ не розглядає", "Національний банк не розглядає анонімні зверненням без імені автора та зазначення місця його проживання. " +
                "Питання поза компетенцією НБУ ми пересилаємо до відповідального державного органу та обов’язково повідомляємо про це людину. " +
                "Якщо громадянин не вказав достатньо інформації, ми повертаємо звернення та просимо уточнити дані. " +
                "Також не розглядається повторне звернення з того ж питання, якщо перше звернення було вирішене." },
        { "За скільки часу отримаю відповідь", "Відповідь на стандартне звернення надається упродовж 30 днів.\r\n\r\nВодночас, якщо звернення не потребує додаткового вивчення та перевірки, відповідь надається впродовж 15 днів.\r\n\r\nВ окремих складних випадках строк розгляду може бути продовжено до 45 днів. Але Національний банк обов’язково повідомляє про це скаржника." },
        { "Як оскаржити дії чи бездіяльність Національного банку", "Згідно статті 23 Закону України \"Про доступ до публічної інформації\" оскарження рішень, дій чи бездіяльності розпорядників інформації можуть бути оскаржені до керівника розпорядника, вищого органу або суду.\r\n\r\nЗапитувач має право оскаржити:\r\n\r\nвідмову в задоволенні запиту на інформацію;\r\nвідстрочку задоволення запиту на інформацію;\r\nненадання відповіді на запит на інформацію;\r\nнадання недостовірної або неповної інформації;\r\nнесвоєчасне надання інформації;\r\nневиконання розпорядниками обов'язку оприлюднювати інформацію відповідно до статті 15 Закону України \"Про доступ до публічної інформації\";\r\nінші рішення, дії чи бездіяльність розпорядників інформації, що порушили законні права та інтереси запитувача.\r\nОскарження рішень, дій чи бездіяльності розпорядників інформації до суду здійснюється відповідно до Кодексу адміністративного судочинства України." }
    };

        public string GetConsultation(string question)
        {
            if (_responses.ContainsKey(question))
            {
                return _responses[question];
            }
            else
            {
                return "Дане питання не може бути оброблене";
            }
        }
    }
}
