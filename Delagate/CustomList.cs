using Delagate.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate;

public class CustomList<T> : IEnumerable<T>
{
    private T[] array;
    public int Count { get => array.Length; }
    public CustomList()
    {
        array = new T[0];
    }

    public T this[int index]
    {
        get => array[index];
        set => array[index] = value;
    }


    public void Add(T item)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = item;

    }
    public T Find(Predicate<T> predicate)
    {
        foreach (T item in array)
        {
            if (predicate(item))
            {
                return item;
            }
        }
        throw new NotFoundException();
    }
    public List<T> FindAll(Predicate<T> predicate)
    {
        List<T> list = new List<T>();   
        foreach (T item in array)
        {
            if (predicate(item))
            {
                list.Add(item); 
            }
        }
        return list;
    }
    public void Remove(T item)
    {
        for (int i = 0; i < array.Length; i++)
        {
            T num = array[i];
            if (num.Equals(item))
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                Array.Resize(ref array, array.Length - 1);
                return;
            }
        }
        throw new NotFoundException();
    }
    //1 2 3 4 5
    public void RemoveAll(Predicate<T> predicate)
    {
        for (int i = 0; i < array.Length; i++)
        {
            T num = array[i];

            if (predicate(array[i]))
            {
                if (i==array.Length-1)
                {
                    Array.Resize(ref array, array.Length - 1);
                }
                else
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    i--;
                    Array.Resize(ref array, array.Length - 1);
                }
               
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in array)
        {
            yield return item;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return array.GetEnumerator();
    }
}