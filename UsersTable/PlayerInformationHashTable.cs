using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_05_2021_Database_Coursework
{
	public class TwoLinkedList
	{
		public ListElem Head = null;
		public ListElem Tail = null;

		// Иниц. элементов списка
		public class ListElem
		{
			public ListElem Prev { get; set; }
			public PlayerInformation Info { get; set; }
			public ListElem Next { get; set; }
		};

		// Конструктор
		public TwoLinkedList() { }

		// Очистка списка
		public void Clear()
		{
			if (this.Head == null) return;

			this.Head = null;
			this.Tail = null;
			GC.Collect();
		}

		// Проверка на пустоту
		public bool IsEmpty()
		{
			return this.Head == null && this.Tail == null;
		}

		// Добавление элемента по убыванию
		public bool Add(PlayerInformation info)
        {
			if (this.FindElem(info) != null) return false;

			var Elem = new ListElem();
			Elem.Info = (PlayerInformation)info.Clone();

			if (this.Head == null)
            {
				this.Head = Elem;
				this.Tail = Elem;
				return true;
            }

			this.Tail.Next = Elem;
			this.Tail = this.Tail.Next;

			return true;
		}

		public bool Remove(PlayerInformation info)
        {
			var elem = this.FindElem(info);
			if (elem != null)
            {
				if (elem.Prev != null)
                {
					if (elem.Next != null)
						elem.Prev.Next = elem.Next;
					else
                    {
						elem.Prev.Next = null;
						this.Tail = elem.Prev;
					}
				}

				if (elem.Next != null)
				{
					if (elem.Prev != null)
						elem.Next.Prev = elem.Prev;
					else
					{
						elem.Next.Prev = null;
						this.Head = elem.Next;
					}
				}
				GC.Collect();
				return true;
			}
			return false;
        }

		// Поиск по логину
		public PlayerInformation FindElemInfo(string login)
        {
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info.Login == login) return mover.Info;
				mover = mover.Next;
			}
			return null;
		}

		// Поиск по всей информации
		public PlayerInformation FindElemInfo(PlayerInformation info)
		{
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info.Login == info.Login && mover.Info.Age == info.Age) return mover.Info;
				mover = mover.Next;
			}
			return null;
		}

		// Поиск элемента в списке
		private ListElem FindElem(PlayerInformation info)
		{
			ListElem mover = this.Head;
			while (mover != null)
			{
				if (mover.Info.Login == info.Login && mover.Info.Age == info.Age) return mover;
				mover = mover.Next;
			}
			return null;
		}
	};

	public class HashTable
	{
		private const int SIZE = 10000;
		private TwoLinkedList[] Table = new TwoLinkedList[SIZE]; 

		public HashTable()
        {
			for (int i = 0; i < SIZE; i++)
            {
				Table[i] = new TwoLinkedList();
            }
        }

		// Хэш-функция - ключ логин
		private int hashFunc(PlayerInformation info)
		{
			string login = info.Login;

			int key = 0;

			foreach (char ch in login)
			{
				key += (int)ch;
			}

			key = key * key;
			key = key >> 11; // Отбрасываем 11 младших бит
			key = key % 1024; // Возвращаем 10 младших бит

			return key % SIZE;
		}

		public bool Add(PlayerInformation info)
		{
			int key = hashFunc(info);
			bool SuccessfulAdd = Table[key].Add(info);

			//if (SuccessfulAdd)
			//{
			//	//
			//}
			//else
			//{
			//	//
			//}
			return SuccessfulAdd;
		}

		public PlayerInformation Find(PlayerInformation info)
		{
			int key = hashFunc(info);

			PlayerInformation ElemContainer = Table[key].FindElemInfo(info);
			if (ElemContainer != null)
			{
				return ElemContainer;
			}
			else
			{
				return null;
			}
		}

		public bool Remove(PlayerInformation info)
		{
			int key = hashFunc(info);
			bool SuccessfulDelete = Table[key].Remove(info);
			//if (SuccessfulDelete)
			//{
				
			//}
			//else
			//{
				
			//}
			return SuccessfulDelete;
		}

		public void ClearHashTable()
		{
			for (int i = 0; i < SIZE; i++)
			{
				Table[i].Clear();
			}
		}
	};
}
