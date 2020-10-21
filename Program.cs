using System;
using DesignPatterns;

namespace design_patterns_in_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Decorators
      Component simple = new ConcreteComponent();
      DecoratorAlpha decoratorAlpha = new DecoratorAlpha(simple);
      DecoratorBeta decoratorBeta = new DecoratorBeta(decoratorAlpha);
      Console.WriteLine(simple.Operation());
      Console.WriteLine(decoratorAlpha.Operation());
      Console.Write(decoratorBeta.Operation());
    }
  }
}
