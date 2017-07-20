using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitWorld
{
    public  class Runner
    {
        public Runner()
        {

        }

        public void Run()
        {
            var runner = new Runner();
            runner.Run();

            var calculator = new Calculator();
            int sum = calculator.Add(5, 7);
            Console.WriteLine(sum);
        }
    

    }
}
