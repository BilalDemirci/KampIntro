using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits) //İngilizcem yetmedi
        { 
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
