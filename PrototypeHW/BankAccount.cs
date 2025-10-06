namespace PrototypeHW
{
    /// <summary>
    /// Класс банковский счет 
    /// </summary>
    public class BankAccount : BankEntity, IMyCloneable<BankAccount>, ICloneable
    {
        //Свойство балланс
        public decimal Balance { get; set; }
        //Конструктор класса 
        public BankAccount(string name, decimal balance) : base(name)
        {
            Balance = balance;
        }
        //Конструктор клона реализующий интерфейс IMyClonable 
        public virtual BankAccount MyClone()
        {
            return new BankAccount(Name, Balance);
        }

        public override string ToString() => $"Account: {Name}, Balance: {Balance}";
        // Реализация стандартного реализацию стандартного интерфейса ICloneable 
        object ICloneable.Clone() => MyClone();
    }
}