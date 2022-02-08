namespace DesignPatternsExample.Prototype
{
    public abstract class Prototype
    {
        Guid _id;
        public Prototype(Guid id)
        {
            _id = id;
        }

        public Guid Id 
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}