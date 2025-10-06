namespace PrototypeHW
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ КЛОНИРОВАНИЯ ===\n");

            // Менеджер оригинал экземпляр 
            var originalManager = new Manager("Alice", "Lead Manager", 5);
            // Клонирование через IMyCloneable
            var clonedManager = originalManager.MyClone();
            // Клонирование через ICloneable
            var iClonedManager = (Manager)((ICloneable)originalManager).Clone();

            PrintCloneTest("Manager", originalManager, clonedManager, iClonedManager);

            // Изменяем оригинальный объект
            var originaManagerChange = originalManager; 
            originalManager.Name += " (Changed)";
            originalManager.TeamSize += 1;
            originalManager.Position += " (Updated)";

            PrintCloneTest("Manager измененеый", originalManager, originaManagerChange);

            // Кредитный счет оиргинал 
            var originalCredit = new CreditAccount("Bob", 10000, 5000);
            // Клонирование через IMyCloneable
            var clonedCredit = originalCredit.MyClone();
            // Клонирование через ICloneable
            var iClonedCredit = (CreditAccount)((ICloneable)originalCredit).Clone();

            PrintCloneTest("CreditAccount", originalCredit, clonedCredit, iClonedCredit);

            // Обычный сотрудник оригинал 
            var originalEmployee = new BankEmployee("Carol", "Clerk");
            // Клонирование через IMyCloneable
            var clonedEmployee = originalEmployee.MyClone();
            // Клонирование через ICloneable
            var iClonedEmployee = (BankEmployee)((ICloneable)originalEmployee).Clone();

            PrintCloneTest("BankEmployee", originalEmployee, clonedEmployee, iClonedEmployee);
            
            // Обычный счет
            var originalAccount = new BankAccount("Dave", 2000);
            // Клонирование через IMyCloneable
            var clonedAccount = originalAccount.MyClone();
            // Клонирование через ICloneable
            var iClonedAccount = (BankAccount)((ICloneable)originalAccount).Clone();

            PrintCloneTest("BankAccount", originalAccount, clonedAccount, iClonedAccount);
            
            Console.ReadKey();
        }
       /// <summary>
       /// Вывод на экран 
       /// </summary>
       /// <param name="title"></param> Наименование  
       /// <param name="original"></param> Оригинальный объект 
       /// <param name="myClone"></param> Клонированный ImyClonable 
       /// <param name="iClone"></param> IClonable метод 
        static void PrintCloneTest(string title, object original, object myClone, object iClone)
        {
            Console.WriteLine($"--- {title} ---");
            Console.WriteLine("Original     : " + original);
            Console.WriteLine("MyClone()    : " + myClone);
            Console.WriteLine("ICloneable   : " + iClone);
            Console.WriteLine("Same object? (original == myClone): " + ReferenceEquals(original, myClone));
            Console.WriteLine("Same object? (original == iClone): " + ReferenceEquals(original, iClone));
            Console.WriteLine();
        }
        /// <summary>
        /// Перегрузка метода вывода сравнения 
        /// </summary>
        /// <param name="title"></param> Наименование 
        /// <param name="original"></param> Оригинальный объект 
        /// <param name="myChange"></param> Оригинальный измененый обект 
        static void PrintCloneTest(string title, object original, object myChange)
        {
            Console.WriteLine($"--- {title} ---");
            Console.WriteLine("Original     : " + original);
            Console.WriteLine("MyChange()    : " + myChange);
            Console.WriteLine("Same object? (original == myChange): " + ReferenceEquals(original, myChange));
            Console.WriteLine();
        }
    }
}