using ParadigmaTeste.Interfaces;
using ParadigmaTeste.Services;
using System;

namespace ParadigmaTeste
{
  public class Program
  {
    private static void Main(string[] args)
    {
      IAtribuirValorArvore atribuirValorArvoreService = new AtribuirValorArvore();
      IMontarArvore montarArvoreService = new MontarArvore();

      int[] entradaCenarioUm = { 3, 2, 1, 6, 0, 5 };
      int[] entradaCenarioDois = { 7, 5, 13, 9, 1, 6, 4 };

      Console.WriteLine("arvore do cenario um:");
      montarArvoreService.ImprimirArvore(atribuirValorArvoreService.GetArvoreProps(entradaCenarioUm));

      Console.WriteLine("arvore do cenario dois:");
      montarArvoreService.ImprimirArvore(atribuirValorArvoreService.GetArvoreProps(entradaCenarioDois));
    }
  }
}