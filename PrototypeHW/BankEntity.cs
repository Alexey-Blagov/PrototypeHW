namespace PrototypeHW
{
    /// <summary>
    /// Базовый класс родитель 
    /// </summary>
    public class BankEntity : IMyCloneable<BankEntity>, ICloneable
    {
        public string Name { get; set; }

        public BankEntity(string name)
        {
            Name = name;
        }

        //Конструктор клона реализующий интерфейс IMyClonable 
        public virtual BankEntity MyClone()
        {
            return new BankEntity(Name);
        }


        public object Clone()
        {
            return MyClone();
        }

        public override string ToString() => $"BankEntity: {Name}";
    }
}