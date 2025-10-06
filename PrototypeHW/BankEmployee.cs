namespace PrototypeHW
{
    /// <summary>
    /// Класс банковские рабочие 
    /// </summary>
    public class BankEmployee : BankEntity, IMyCloneable<BankEmployee>, ICloneable
    {
        public string Position { get; set; }
        //Конструктор класса 
        public BankEmployee(string name, string position) : base(name)
        {
            Position = position;
        }
        //Конструктор клона реализующий интерфейс IMyClonable 
        public virtual BankEmployee MyClone()
        {
            return new BankEmployee(Name, Position);
        }

        public override string ToString() => $"Employee: {Name}, Position: {Position}";
        // Реализация стандартного реализацию стандартного интерфейса ICloneable 
        object ICloneable.Clone() => MyClone();
    }
}