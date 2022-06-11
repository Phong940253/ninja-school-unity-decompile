using System.Collections;

public class mHashtable
{
	public Hashtable h = new Hashtable();

	public object get(object k)
	{
		return h[k];
	}

	public object conskey(string key)
	{
		return h[key];
	}

	public void clear()
	{
		h.Clear();
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return h.GetEnumerator();
	}

	public int size()
	{
		return h.Count;
	}

	public void put(object k, object v)
	{
		if (h.ContainsKey(k))
		{
			h.Remove(k);
		}
		h.Add(k, v);
	}

	public void remove(object k)
	{
		h.Remove(k);
	}

	public void Remove(string key)
	{
		h.Remove(key);
	}
}
