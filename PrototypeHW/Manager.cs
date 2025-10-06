namespace PrototypeHW
{
    /// <summary>
    /// Класс менеджер
    /// </summary>
    public class Manager : BankEmployee, IMyCloneable<Manager>, ICloneable
    {
        public int TeamSize { get; set; }

        public Manager(string name, string position, int teamSize)
            : base(name, position)
        {
            TeamSize = teamSize;
        }
        //Конструктор клона реализующий интерфейс IMyClonable 
        public override Manager MyClone()
        {
            return new Manager(Name, Position, TeamSize);
        }

        public override string ToString() =>
            $"Manager: {Name}, Position: {Position}, TeamSize: {TeamSize}";
        // Реализация стандартного интерфейса ICloneable 
        object ICloneable.Clone() => MyClone();
    }
}