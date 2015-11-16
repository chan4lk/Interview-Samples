using System;
using System.Diagnostics;

namespace Interview
{
    class Concreate1 : IBase1, IBase2
    {
        public virtual void Kill()
        {
            var obj = new object();

            int l;

            var sucess = int.TryParse("123", out l);

            Debug.WriteLine("kill me");
        }
    }
}
