using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HartwickHorseRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hartwick horse racing:" + Environment.NewLine + "Press any key to start!");
            Console.ReadKey();

            threadingClass app = new threadingClass();
            app.horse1props = new Thread(new ThreadStart(app.RunCourse));
            app.horse2props = new Thread(new ThreadStart(app.RunCourse));
            app.horse3props = new Thread(new ThreadStart(app.RunCourse));
            app.horse4props = new Thread(new ThreadStart(app.RunCourse));
            app.horse5props = new Thread(new ThreadStart(app.RunCourse));
            app.horse1props.Name = "Ron";
            app.horse2props.Name = "Matt";
            app.horse3props.Name = "Brian";
            app.horse4props.Name = "Demitri";
            app.horse5props.Name = "Robert";
            app.horse1props.Start();
            app.horse2props.Start();
            app.horse3props.Start();
            app.horse4props.Start();
            app.horse5props.Start();
            Console.ReadKey();
        }
    }
}
