using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class DynamicArray
	{
		private int[] items;

		private int size = 0;
		public void InsertRange(int index, int[] array)
		{
			// реализуйте данный метод
			foreach(var elem in array)
            {
				this.Insert(index, elem);
				index += 1;
            }
		}
		public void PushBackRange(int[] array)
		{
			// реализуйте данный метод
			foreach (var elem in array)
            {
				this.PushBack(elem);
            }
		}
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
		{
			int newCount = size * 2;
			if (size == 0)
			{
				newCount = 4;
			}

			var newArray = new int[newCount];
			for (int i = 0; i < size; i++)
			{
				newArray[i] = items[i];
			}

			items = newArray;
		}

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
		{
			if (size == 0)
			{
				throw new Exception("Массив пустой.");
			}
			size--;
		}

		public void RemoveByIndex(int index)
		{
			if (size == 0)
			{
				throw new Exception("Массив пустой!");
			}
			if (index < 0 || index >= size)
			{
				throw new Exception("Выход за пределами массива");
			}
			for (int i = index + 1; i < size; i++)
			{
				items[i - 1] = items[i];
			}
			size--;
		}

		public void PopFront()
		{
			RemoveByIndex(0);
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
                
        }
    }
}