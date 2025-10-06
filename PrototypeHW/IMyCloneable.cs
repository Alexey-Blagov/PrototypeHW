namespace PrototypeHW
{
    // Дженерик интерфейс для реализации шаблона "Прототип"
    public interface IMyCloneable<T>
    {
        T MyClone();
    }
}