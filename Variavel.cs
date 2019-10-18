using System;

namespace C__Examples {
    public class Variavel {
        // tipos primitivos: string, int, bool, char, float
        private string nome;
        private int idade;
        private bool isAdmin;
        private char genero;
        private float peso;
        private double salario;

        // readonly não pode usar dentro de métodos, para isso use const
        // readonly string name = "LUiz Filipy";
        public void test () {

            // const string hello = "Olá Mundo";

            Console.WriteLine ("Digite seu nome:");
            // Console.ReadLine() -> pega o input do usuario
            this.nome = Console.ReadLine ();

            Console.WriteLine ("Digite sua idade:");
            this.idade = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Você é admin? (true ou false)");
            this.isAdmin = bool.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual o seu genero (M: masculino ou F: feminino)");
            this.genero = char.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual é o seu peso?");
            this.peso = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Qual o seu salário?");
            this.salario = double.Parse (Console.ReadLine ());

            Console.WriteLine ("Bem vindo " + this.nome + ".");
            Console.WriteLine ("Você tem " + this.idade + " de idade.");
            Console.WriteLine ("isAdmin: " + this.isAdmin);
            Console.WriteLine ("Seu genero é: " + this.genero);
            Console.WriteLine ("Você pesa " + this.peso + "kg");
            Console.WriteLine ("Seu salário: " + this.salario);
            Console.WriteLine ("-------------------------------------------");
        }
    }
}