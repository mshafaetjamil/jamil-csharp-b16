using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMachine
    {
        void Start();
        void Stop();

        public void BeginWork()
        {
            Console.WriteLine("Machine Working");
        }
    }
}
