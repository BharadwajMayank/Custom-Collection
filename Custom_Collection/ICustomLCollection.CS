
namespace CustomCollection
{
public interface ICustomCollection<T>
    {
        void Add(T item);
        bool Remove(T item);
        bool Contains(T item);

        // Additional math functions
        T Sum();
        T Average();
        T Product();
        T Maximum();
        T Minimum();
        T GetMedian();
    }
}

