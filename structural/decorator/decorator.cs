namespace DesignPatterns
{
  public abstract class Component
  {
    public abstract string Operation();
  }

  public class ConcreteComponent : Component
  {
    public override string Operation()
    {
      return "Concrete component";
    }
  }

  public abstract class Decorator : Component
  {
    protected Component _component { get; set; }

    public Decorator(Component component)
    {
      this._component = component;
    }

    public override string Operation()
    {
      if (this._component != null)
      {
        return this._component.Operation();
      }
      else
      {
        return string.Empty;
      }
    }
  }

  public class DecoratorAlpha : Decorator
  {
    public DecoratorAlpha(Component component) : base(component) { }
    public override string Operation()
    {
      return "Decorator alpha " + this._component.Operation();
    }
  }
  public class DecoratorBeta : Decorator
  {
    public DecoratorBeta(Component component) : base(component) { }
    public override string Operation()
    {
      return "Decorator beta " + this._component.Operation();
    }
  }
}