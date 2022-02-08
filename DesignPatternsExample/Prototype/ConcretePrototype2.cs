namespace DesignPatternsExample.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2() : base(Guid.NewGuid())
        {            
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}