using System;

public class NumeroComplesso
{
    private double parteReale;
    private double parteImmaginaria;

    public NumeroComplesso(double parteReale = 0, double parteImmaginaria = 0)
    {
        this.parteReale = parteReale;
        this.parteImmaginaria = parteImmaginaria;
    }

    public static NumeroComplesso Somma(NumeroComplesso a, NumeroComplesso b)
    {
        return new NumeroComplesso(a.parteReale + b.parteReale, a.parteImmaginaria + b.parteImmaginaria);
    }

    public static NumeroComplesso Sottrai(NumeroComplesso a, NumeroComplesso b)
    {
        return new NumeroComplesso(a.parteReale - b.parteReale, a.parteImmaginaria - b.parteImmaginaria);
    }

    public static NumeroComplesso Moltiplica(NumeroComplesso a, NumeroComplesso b)
    {
        double parteReale = a.parteReale * b.parteReale - a.parteImmaginaria * b.parteImmaginaria;
        double parteImmaginaria = a.parteReale * b.parteImmaginaria + a.parteImmaginaria * b.parteReale;
        return new NumeroComplesso(parteReale, parteImmaginaria);
    }

    public static NumeroComplesso Dividi(NumeroComplesso a, NumeroComplesso b)
    {
        double denominatore = b.parteReale * b.parteReale + b.parteImmaginaria * b.parteImmaginaria;
        double parteReale = (a.parteReale * b.parteReale + a.parteImmaginaria * b.parteImmaginaria) / denominatore;
        double parteImmaginaria = (a.parteImmaginaria * b.parteReale - a.parteReale * b.parteImmaginaria) / denominatore;
        return new NumeroComplesso(parteReale, parteImmaginaria);
    }

    public override string ToString()
    {
        return $"({parteReale}, {parteImmaginaria})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        NumeroComplesso numero1 = new(3, 5);
        NumeroComplesso numero2 = new(7, 9);

        Console.WriteLine("Somma:");
        Console.WriteLine(NumeroComplesso.Somma(numero1, numero2));

        Console.WriteLine("\nSottrazione:");
        Console.WriteLine(NumeroComplesso.Sottrai(numero1, numero2));

        Console.WriteLine("\nMoltiplicazione:");
        Console.WriteLine(NumeroComplesso.Moltiplica(numero1, numero2));

        Console.WriteLine("\nDivisione:");
        Console.WriteLine(NumeroComplesso.Dividi(numero1, numero2));
    }
}




/*Комплексные числа — это расширение системы вещественных чисел, включающее в себя специальный элемент,
обозначаемый буквой (i) (или (j) в некоторых областях, например, в электротехнике, где (i) часто используется для обозначения тока), называемый мнимой единицей. Мнимая единица обладает свойством, что (i ^ 2 = -1), что позволяет представлять квадратный корень из отрицательных чисел и решать полиномиальные уравнения, которые не имеют решений среди вещественных чисел.

Комплексное число записывается в виде (a + bi), где (a) и (b) — вещественные числа, а (i) — мнимая единица. Часто используемые термины включают:

Реальная часть комплексного числа (a + bi) обозначается как (Re(z)) или просто (a), и представляет собой вещественную часть числа.
Мнимая часть комплексного числа (a + bi) обозначается как (Im(z)) или просто (b), и представляет собой мнимую часть числа.
Комплексное число можно интерпретировать как точку в плоскости комплексных чисел (или Аргандова диаграмма), где горизонтальная ось отображает вещественную часть, а вертикальная ось — мнимую часть.
Комплексные числа играют ключевую роль во многих областях математики и науки, включая электродинамику,
инженерию, физику и многие другие, поскольку они позволяют описывать и решать множество важных задач, которые не могут быть решены с помощью только вещественных чисел.
*/