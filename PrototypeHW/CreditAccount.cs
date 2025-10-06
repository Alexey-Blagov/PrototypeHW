namespace PrototypeHW
{
    /// <summary>
    /// Класс кредитный счет    
    /// </summary>
    public class CreditAccount : BankAccount, IMyCloneable<CreditAccount>, ICloneable
    {
        public decimal CreditLimit { get; set; }

        public CreditAccount(string name, decimal balance, decimal creditLimit)
            : base(name, balance)
        {
            CreditLimit = creditLimit;
        }
        //Конструктор клона реализующий интерфейс IMyClonable 
        public override CreditAccount MyClone()
        {
            return new CreditAccount(Name, Balance, CreditLimit);
        }

        public override string ToString() =>
            $"CreditAccount: {Name}, Balance: {Balance}, CreditLimit: {CreditLimit}";
        // Реализацию стандартного интерфейса ICloneable 
        object ICloneable.Clone() => MyClone();
    }
}