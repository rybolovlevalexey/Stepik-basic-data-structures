using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class DynamicArray
	{
		private int[] items;

		private int size = 0;
		public bool Remove(int item)
		{
			// реализуйте данный метод
			for (int ind = 0; ind < this.GetCount(); ind += 1)
            {
				if (items[ind] == item)
                {
					this.RemoveByIndex(ind);
					return true;
                }
            }
			return false;
		}
		public int RemoveAll(int item)
		{
			// реализуйте данный метод
			int cnt = 0;
			int ind = 0;
			while (ind < size)
            {
				if (items[ind] == item)
                {
					this.RemoveByIndex(ind);
					cnt += 1;
                }
					
				else
					ind += 1;
            }
			return cnt;
		}
		public DynamicArray(int length)
		{
			items = new int[length];
		}
		public DynamicArray()
		{
			items = new int[0];
		}

		public string Print()
		{
			string result = "";
			for (int i = 0; i < size; i++)
			{
				result += items[i] + " ";
			}

			return result;
		}

		public int GetCount()
		{
			return size;
		}

		public int Get(int index)
		{
			if (index >= size || index < 0)
			{
				throw new Exception("Индекс находится за пределами массива.");
			}

			return items[index];
		}

		public int Find(int key)
		{
			for (int i = 0; i < size; i++)
			{
				if (items[i] == key)
				{
					return i;
				}
			}

			return -1;
		}

		public void PushBack(int item)
		{
			if (size == items.Length)
			{
				IncreaseArray();
			}

			items[size] = item;
			size++;
		}

		private void IncreaseArray()
		{ }

		public void Insert(int index, int item)
		{
			if (index < 0 || index > size)
			{
				throw new Exception("Выход за пределами массива");
			}

			if (size == items.Length)
			{
				IncreaseArray();
			}

			// сдвигаем все элементы вправо до нужного индекса
			for (int i = size - 1; i >= index; i--)
			{
				items[i + 1] = items[i];
			}

			items[index] = item;
			size++;
		}

		public void PushFront(int item)
		{
			Insert(0, item);
		}

		public void PopBack()
		{ }

		public void RemoveByIndex(int index)
		{ }

		public void PopFront()
		{ }
	}
	class Program
    {
        static void Main(string[] args)
        {
                
        }
    }
}