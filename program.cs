using System;
using System.Collections.Generic;
using System.Linq;
					
public interface ISomavel
{
    ISomavel soma(ISomavel b);
}

class numero: ISomavel
{
    public int teste;

    public numero(int valor)
    {
        teste = valor;
    }

    public ISomavel soma(ISomavel b)
    {
        return new numero(this.teste + ((numero)b).teste);
    }
}


class Auxiliar
{
    public static ISomavel SomaTudo(List<ISomavel> lista)
    {
        ISomavel somado = lista[0];
        foreach (var item in lista.Skip(1))
        {
            somado = somado.soma(item);
        }
        return somado;
    }
}

public class Program
{
    public static void Main()
    {
        List<ISomavel> numeros = new List<ISomavel>() {
            new numero(1),
            new numero(2),
            new numero(3),
            new numero(4),
            new numero(5),
        };
        numero resultado = (numero)Auxiliar.SomaTudo(numeros);
        Console.WriteLine(resultado.teste);
        
    }
}