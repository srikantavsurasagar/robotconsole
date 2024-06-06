using System;
using System.IO;
using System.Linq;

namespace robotconsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExecuteCommandsFrom("C:\\Users\\v-ssurasagar\\source\\repos\\Robot\\robotconsole\\Input2.txt");

            Console.ReadLine();
        }
        private static void ExecuteCommandsFrom(string path)
        {
            var toyRobot = new toyrobot();
            var simulator = new Simulator(toyRobot);

            using (var file = new StreamReader(path))
            {
                string command;
                while ((command = file.ReadLine()) != null)
                {
                    Console.WriteLine("Executing command: " + command);
                    simulator.Execute(command);
                }
            }
        }
    }
}
