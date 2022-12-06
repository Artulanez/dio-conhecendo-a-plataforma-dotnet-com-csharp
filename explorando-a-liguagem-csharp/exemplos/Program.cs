﻿using exemplos.models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value} ");
// }

// Console.WriteLine("-----------------");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - elemento alterado";
// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value} ");
// }

string chave = "BA";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave)) 
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

// Stack<int> pilha = new  Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }



// ExemploExcecao exemploExcecao = new ExemploExcecao();
// exemploExcecao.metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("arquivos/arquivo-Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrada {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

//////////////////////////
// string dataString = "2022-07-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! data:{data}");
// }
// else
// { 
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

////////////////////////////////////
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40m;

// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3909;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


//////////////////////////////
// String numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

/////////////////////////////
// Pessoa p1 = new Pessoa("Artulanez","Souza",32);
// Pessoa p2 = new Pessoa("Lucrecia","Cariolano",34);

// Curso cursoDeIngles = new Curso("Ingles");

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

