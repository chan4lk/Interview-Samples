using System.Diagnostics;

namespace Interview
{
    class Concreate2 : Concreate1
    {
        public override void Kill()
        {
            Debug.WriteLine("kill me 2");
        }
    }
}
