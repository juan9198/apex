using System;

namespace exercicio {
    class Program {
        static void Main (string[] args) {]
        int[] listaDeNumeros = new int[5];

        for (int i = 0; i < listaDeNumeros.Length; i++) {
            Console.WriteLine ($"Informe o {i + 1} numero: ");
            listaDeNumeros[i] = Convert.ToInt32 (Console.ReadLine);
        }

        int contadorImpar = 0;
        int contadorPar = 0;
        foreach (int numero in listaDeNumeros) {
            if (numero % 2 == 0) {
                contadorImpar++;
            } else {
                contadorPar++;
            }
            Console.WriteLine ($"Quantidades de pares: {contadorPar}");
            Console.WriteLine ($"Quantidades de impares: {contadorImpar}");
        }

    }
}