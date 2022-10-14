public class HandyMethods {
    public T Max<T>(List<T> maxList) where T : IComparable{
        T max = maxList[0];
        foreach(T item in maxList){
            max = max.CompareTo(item) > 0? max : item;
        }
        return max;
    }
       public T Min<T>(List<T> minList) where T : IComparable{
        T min = minList[0];
        foreach(T item in minList){
            min = min.CompareTo(item) < 0? min : item;
        }
        return min;
    }
}