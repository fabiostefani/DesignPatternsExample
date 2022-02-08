namespace DesignPatternsExample.Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1() : base(Guid.NewGuid())
        {            
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}