using System.Diagnostics;

namespace Interview
{
    class Concreate3 : Concreate1
    {
        public new void Kill()
        {
            Debug.WriteLine("kill me 3");
        }

        public void Test()
        {
            this.Kill();
        }
    }
}
