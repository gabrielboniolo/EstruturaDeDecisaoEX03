using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite a sua altura em cm: ");
    int altura = int.Parse(Console.ReadLine());
    if (altura <= 175) {
      Console.Write("Digite seu peso em kg: ");
      int peso1 = int.Parse(Console.ReadLine());
      if (peso1 <= 75) {
        Console.WriteLine ("Você está no peso ideal.");
      }
        else {
          Console.WriteLine ("Você está fora do peso ideal.");
        }
    }
        else {
          Console.Write("Coloque o seu peso em kilos: ");
          int peso2 = int.Parse(Console.ReadLine());

          if (peso2 <= 85) {
            Console.WriteLine ("Está com o peso em dia.");
          }
          else {
            Console.WriteLine ("Fora de forma.");
          }
        }
    }
  }