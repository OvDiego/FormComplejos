using System;
using System.CodeDom;
using System.Runtime.InteropServices.ComTypes;

namespace FormComplejos_G2_2024_1
{
    internal class Complejo
    {
        private float real;
        private float imaginario;

        public Complejo(float real, float imaginario)
        {
            this.real = real;
            this.imaginario = imaginario;
        }

        //no necesita instancias 
        // se pone + para indicar suma
        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo(c1.real + c2.real, c1.imaginario + c2.imaginario);
            return c3;
            //return new Complejo(c1.real + c2.real,c1.imaginario+c2.imaginario);
        }
        
        
        public static Complejo operator -(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo(c1.real - c2.real, c1.imaginario - c2.imaginario);
            return c3;
            //return new Complejo(c1.real + c2.real,c1.imaginario+c2.imaginario);
        }

        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo(c1.real * c2.real - c1.imaginario * c2.imaginario,  c1.real * c2.imaginario + c2.real * c1.imaginario);
            return c3;
            //return new Complejo(c1.real + c2.real,c1.imaginario+c2.imaginario);
        }



        public static Complejo operator ~(Complejo c)
        {
            return new Complejo(c.real, -c.imaginario);
        }
           

        public override string ToString()
        {
            if (imaginario>=0)

            return String.Format(" {0} + {1}i   ", real, imaginario);

            else
                return String.Format(" {0}  {1}i   ", real, imaginario);


        }






    }
}
