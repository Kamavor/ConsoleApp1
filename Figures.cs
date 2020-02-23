using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Figures
    {

        private double measure1, measure2, measure3;
        private int Figure_Type; // 1 - circle, 2 - trangle

        public Figures(double input1, double input2, double input3, int input4)
        {
            this.measure1 = input1; 
            this.measure2 = input2;
            this.measure3 = input3;
            this.Figure_Type = input4;
        }


        public double Square() 
        {
            switch (Figure_Type)
            {
                case 1:
                    {
                        return measure1 * measure1 * Math.PI;
                    }
                case 2:
                    {
                        double p;
                        p = (measure1 + measure2 + measure3) / 2;
                        return Math.Sqrt(p * (p - measure1) * (p - measure2) * (p - measure3));
                    }
                default:
                    {
                        return 0;
                    }
            }         
        }
         public bool Rectangular()
         {
            
            switch (Figure_Type)
            {
                case 2:
                    {
                        if (is_Rect(measure1, measure2, measure3) | is_Rect(measure3, measure2, measure2) | is_Rect(measure3, measure2, measure1))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default:
                    {
                        return false;
                    }
            }
         }
        private bool is_Rect(double x1, double x2, double x3)
        {
            if ((Math.Sqrt(x1 * x1 + x2 * x2) <= x3+0.0001) & (Math.Sqrt(x1 * x1 + x2 * x2) >= x3 - 0.0001))
                return true;
            else return false;
        }
    }

}