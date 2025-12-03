using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using kyrk.parameter;

namespace pid_identification_example_project
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double Tf = 3.0;//[s]
                double Th = 8.0;//[s]
                piwinger piwinger = new piwinger();
                PID_Types PID_Types = piwinger.piwingerCalculation(Tf, Th);
                Console.Out.WriteLine("Tf=" + Tf.ToString().Replace(',', '.') + " Th=" + Th.ToString().Replace(',', '.') + "s");
                Console.Out.WriteLine("PID type suggested: " + PID_Types.ToString());
            }
            {
                double Tf = 15.0;//[s]
                double Th = 7.0;//[s]
                piwinger piwinger = new piwinger();
                PID_Types PID_Types = piwinger.piwingerCalculation(Tf, Th);
                Console.Out.WriteLine("Tf=" + Tf.ToString().Replace(',', '.') + " Th=" + Th.ToString().Replace(',', '.') + "s");
                Console.Out.WriteLine("PID type suggested: " + PID_Types.ToString());
            }
            {
                double Ap = 10.0;
                double Th = 8.0;//[s]
                double T1 = 5.0;//[s]
                HPT1_Parameters hpt1_parameters = new HPT1_Parameters(Ap, Th, T1);
                cohencoon cohencoon = new cohencoon();
                PID_Parameters PID_Parameters;
                Console.Out.WriteLine("Cohen-Coon Method P");
                PID_Parameters = cohencoon.cohencoon_calculate_P(hpt1_parameters);
                hpt1_parameters.Print();
                PID_Parameters.Print();
                Console.Out.WriteLine("Cohen-Coon Method PI");
                PID_Parameters = cohencoon.cohencoon_calculate_PI(hpt1_parameters);
                hpt1_parameters.Print();
                PID_Parameters.Print();
                Console.Out.WriteLine("Cohen-Coon Method PID");
                PID_Parameters = cohencoon.cohencoon_calculate_PID(hpt1_parameters);
                hpt1_parameters.Print();
                PID_Parameters.Print();
            }

            {
                double Ap = 10.0;
                double Th = 8.0;//[s]
                double T1 = 5.0;//[s]
                HPT1_Parameters hpt1_parameters = new HPT1_Parameters(Ap, Th, T1);
                chr chr = new chr();
                PID_Parameters PID_Parameters;
                Console.Out.WriteLine("Chien-Hrones-Reswick");
                PID_Parameters = chr.chr_calculate_step_PID(hpt1_parameters, false);
                hpt1_parameters.Print();
                PID_Parameters.Print();
            }

        }
    }
}
