﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalcoliHelper
{
    public static int Somma(int num1, int num2) => num1 + num2;
    public static double Somma(double num1, double num2) => num1 + num2;
    public static int Differenza(int num1, int num2)
    {
        if ((num1 - num2) > 0)
        {
            return num1 - num2;
        }
        else
        {
            return (num1 - num2) * -1;
        }
    }
    public static double Differenza(double num1, double num2)
    {
        if ((num1 - num2) > 0)
        {
            return num1 - num2;
        }
        else
        {
            return (num1 - num2) * -1;
        }
    }
    public static int Moltiplicazione(int num1, int num2) => num1 * num2;
    public static double Moltiplicazione(double num1, double num2) => num1 * num2;
    public static int ValoreAssoluto(int num1)
    {
        if (num1 > 0)
        {
            return num1;
        }
        else
        {
            return num1 * -1;
        }
    }
    public static double ValoreAssoluto(double num1)
    {
        if (num1 > 0)
        {
            return num1;
        }
        else
        {
            return num1 * -1;
        }
    }
    public static int MinimoTra(int num1, int num2)
    {
        if (num1 > num2) 
        {
            return num2;
        }
        else
        {
            return num1;
        }
    }
    public static double MinimoTra(double num1, double num2)
    {
        if (num1 > num2)
        {
            return num2;
        }
        else
        {
            return num1;
        }
    }
    public static int MassimoTra(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    public static double MassimoTra(double num1, double num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    public static int ElevazioneAPotenza(int num1, int num2)
    {
        if ((num1 == 0 && num2 == 0) || (num1 != 0 && num2 == 0))
        {
            return 1;
        }
        else if (num1 == 0 && num2 != 0)
        {
            return 0;
        }
        else if (num2 == 1 )
        {
            return num1;
        }
        else
        {
            int risultato = num1;
            int temp;

            for(int i = 0; i < num2 - 1; i++)
            {
                temp = risultato * num1;
                risultato = temp;
            }
            return risultato;
        }



    }


}

// Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi si chiama OVERLOADING.
