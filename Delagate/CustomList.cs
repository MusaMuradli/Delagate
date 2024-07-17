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
    private List<T> values;
    public CustomList()
    {
        values = new List<T>();
    }
    public void Add(T item)
    {
        values.Add(item);
    }
    public T Find(Predicate<T> item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        foreach (T value in values)
        {
            if (item(value))
            {
                return value;
            }
        }

        return default(T);
    }
    public List<T> FindAll(Predicate<T> item)
    {
        if (item == null)
        {
            throw new NotFoundException(nameof(item));
        }

        List<T> result = new List<T>();

        foreach (T value in values)
        {
            if (item(value))
            {
                result.Add(value);
            }
        }

        return result;
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}