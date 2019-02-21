using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool ris = true;
            if (a == 0)
            {
                ris = false;
            }
            return ris;
        }
        public static bool IsnotDetermined(double a, double b)
        {
            bool ris = false;
            if (a == 0 && b == 0)
            {
                ris = true;
            }
            return ris;
        }

        public static bool Isinconsisted(double a,double b)
        {
            bool ris = false;
            if (a == 0 && b!=0)
            {
                ris = true;
            }
            return ris;
        }
        public static bool IsDegree2(double a)
        {
            bool ris = true;
            if (a == 0)
            {
                ris = false;
            }
            return ris;
        }
        public static double Delta(double a,double b,double c)
        {
            return (b * b) - (4*(a * c));
        }
        public static string EquationDegree1(double a, double b)
        {
            
            string ris = "";
           if(IsnotDetermined(a,b))
           {
                ris = "indeterminato";
           }
           else if(Isinconsisted(a,b))
           {
                ris="impossibile";
           }
           else
           {
                ris = Convert.ToString(b / a);
           }
            return ris;
        }
        public static string EquationDegree2(double a, double b,double c)
        {
            
            string risposta = "";
            if(IsnotDetermined(a,b))
            {
                risposta = "indeterminato";
            }
            else if(Delta(a,b,c)<0)
            {
                risposta = "impossibile";
            }
            else
            {
                double m = (-b + Math.Sqrt(b * b - 4 * a * c))/2*a;
                double e = (-b - Math.Sqrt(b * b - 4 * a * c))/2*a;
                risposta=($"{m} e {e}");
            }
            return risposta;
        }
    }
}
