using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_05_2021_Database_Coursework
{
	

	//public class PlayerInformationHashTable
	//{
	//	public class TwoLinkedList
	//	{
	//		public ListElem Head = null;
	//		public ListElem Tail = null;

	//		// Иниц. элементов списка
	//		public class ListElem
	//		{
	//			public ListElem Prev { get; set; }
	//			public PlayerInformation Info { get; set; }
	//			public ListElem Next { get; set; }
	//		};

	//		// Конструктор
	//		public TwoLinkedList() { }

	//		// Очистка списка
	//		public void Clear()
	//		{
	//			if (this.Head == null) return;

	//			this.Head = null;
	//			this.Tail = null;
	//			GC.Collect();
	//		}

	//		// Проверка на пустоту
	//		public bool IsEmpty()
	//		{
	//			return this.Head == null && this.Tail == null;
	//		}

	//		// Добавление элемента по убыванию
	//		public bool Add(PlayerInformation info)
	//		{
	//			if (this.FindElemInfo(info.Login) != null) return false;

	//			var Elem = new ListElem();
	//			Elem.Info = (PlayerInformation)info.Clone();

	//			if (this.Head == null)
	//			{
	//				this.Head = Elem;
	//				this.Tail = Elem;
	//				return true;
	//			}

	//			this.Tail.Next = Elem;
	//			this.Tail = this.Tail.Next;

	//			return true;
	//		}

	//		public bool Remove(PlayerInformation info)
	//		{
	//			var elem = this.FindElem(info);
	//			if (elem != null)
	//			{
	//				if (elem.Prev != null)
	//				{
	//					if (elem.Next != null)
	//						elem.Prev.Next = elem.Next;
	//					else
	//					{
	//						elem.Prev.Next = null;
	//						this.Tail = elem.Prev;
	//					}
	//				}
	//				else
	//				{
	//					this.Head = null;
	//				}

	//				if (elem.Next != null)
	//				{
	//					if (elem.Prev != null)
	//						elem.Next.Prev = elem.Prev;
	//					else
	//					{
	//						elem.Next.Prev = null;
	//						this.Head = elem.Next;
	//					}
	//				}
	//				else
	//				{
	//					this.Tail = null;
	//				}
	//				GC.Collect();
	//				return true;
	//			}
	//			return false;
	//		}

	//		// Поиск по логину
	//		public PlayerInformation FindElemInfo(string login)
	//		{
	//			ListElem mover = this.Head;
	//			while (mover != null)
	//			{
	//				if (mover.Info.Login == login) return mover.Info;
	//				mover = mover.Next;
	//			}
	//			return null;
	//		}

	//		// Поиск по всей информации
	//		public PlayerInformation FindElemInfo(PlayerInformation info)
	//		{
	//			ListElem mover = this.Head;
	//			while (mover != null)
	//			{
	//				if (mover.Info.Login == info.Login && mover.Info.Age == info.Age) return mover.Info;
	//				mover = mover.Next;
	//			}
	//			return null;
	//		}

	//		// Поиск элемента в списке
	//		private ListElem FindElem(PlayerInformation info)
	//		{
	//			ListElem mover = this.Head;
	//			while (mover != null)
	//			{
	//				if (mover.Info.Login == info.Login && mover.Info.Age == info.Age) return mover;
	//				mover = mover.Next;
	//			}
	//			return null;
	//		}
	//	};

 //       private const int Size = 10000;
	//	public int Size
	//	{
	//		get { return Size; }
	//	}

	//	public TwoLinkedList[] Table = new TwoLinkedList[Size];

	//	private MainFrame OriginFrame;

	//	private PlayerInformationHashTable() { }
	//	public PlayerInformationHashTable(MainFrame OriginFrame)
 //       {
	//		this.OriginFrame = OriginFrame;
	//		for (int i = 0; i < Size; i++)
	//		{
	//			Table[i] = new TwoLinkedList();
	//		}
	//	}

	//	// Хэш-функция - ключ логин
	//	private int hashFunc(PlayerInformation info)
	//	{
	//		string login = info.Login;

	//		int key = 0;

	//		foreach (char ch in login)
	//		{
	//			key += (int)ch;
	//		}

	//		key = key * key;
	//		key = key >> 6; // Отбрасываем 6 младших бит
	//		key = key % 32768; // Возвращаем 15 младших бит

	//		return key % Size;
	//	}

	//	public bool Add(PlayerInformation info)
	//	{
	//		int key = hashFunc(info);
	//		bool SuccessfulAdd = Table[key].Add(info);

 //           if (SuccessfulAdd)
 //           {
	//			OriginFrame.AddLog("[Хэш - Игроки-Возраст] Добавлен новый элемент: логин - " + info.Login + ", возраст - " + info.Age + ", хэш: " + key);

	//			//for (int i = 0; i < Size; i++)
 //   //            {
	//			//	OriginFrame.AddLog("=====" + i + "=====");
	//			//	TwoLinkedList.ListElem mover = Table[i].Head;
	//			//	while (mover != null)
 //   //                {
	//			//		OriginFrame.AddLog(mover.Info.Login + " " + mover.Info.Age);
	//			//		mover = mover.Next;
 //   //                }
	//			//}
 //           }
 //           else
 //           {
	//			OriginFrame.AddLog("[Хэш - Игроки-Возраст] Попытка добавить уже существующего пользователя!");
	//		}
 //           return SuccessfulAdd;
	//	}

	//	public PlayerInformation Find(PlayerInformation info)
	//	{
	//		int key = hashFunc(info);

	//		PlayerInformation ElemContainer = Table[key].FindElemInfo(info);
	//		if (ElemContainer != null)
	//		{
	//			return ElemContainer;
	//		}
	//		else
	//		{
	//			return null;
	//		}
	//	}

	//	public bool Remove(PlayerInformation info)
	//	{
	//		int key = hashFunc(info);
	//		bool SuccessfulDelete = Table[key].Remove(info);
	//		//if (SuccessfulDelete)
	//		//{
				
	//		//}
	//		//else
	//		//{
				
	//		//}
	//		return SuccessfulDelete;
	//	}

	//	public void ClearHashTable()
	//	{
	//		for (int i = 0; i < Size; i++)
	//		{
	//			Table[i].Clear();
	//		}
	//	}
	//};

	public class PlayerInformationHashTable // Linear Probing Open Adressing Hash
	{
		private PlayerInformation[] _Hash = new PlayerInformation[1];
		private bool[] _DeletedElementFlags = new bool[1];
		private uint _CountWithDeletedElements = 0;
		private MainFrame _OriginFrame;

		public uint Count { get; private set; } = 0;
		public uint Size { get; private set; } = 1;

		private PlayerInformationHashTable() { }
		public PlayerInformationHashTable(MainFrame OriginFrame)
        {
			_OriginFrame = OriginFrame;
        }

		private void _ResizeHash(uint NewSize)
		{
			var OldHash = _Hash;
			var OldHSize = Size;

			PlayerInformation[] NewHash = new PlayerInformation[NewSize];
			_Hash = NewHash;
			Size = NewSize;
			_CountWithDeletedElements = Count;
			_DeletedElementFlags = new bool[NewSize];
			for (int i = 0; i < OldHSize; i++)
			{
				if (OldHash[i] != null)
					Add(OldHash[i], true);
			}
		}

		private void _ResizeHashIfItsNecessary()
		{
			float FullnessRatio = (float)Count / (float)Size;
			float FullnessRatioWithDeletedElements = (float)_CountWithDeletedElements / (float)Size;

			if (FullnessRatioWithDeletedElements >= 0.7)
			{
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Таблица расширяется");
				_ResizeHash(Size * 2);
			}
			else if (FullnessRatio <= 0.2)
			{
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Таблица сжимается");
				_ResizeHash(Size / 2);
			}
		}

		//// Метод сложения строк с умножением на константу в степени
		//private long HashFunction(string login)
		//{
		//	const int p = 53;
		//	long Hash = 0, p_pow = 1;
		//	for (int i = 0; i < login.Length; i++)
		//	{
		//		Hash += login[i] * p_pow;
		//		p_pow *= p;
		//	}

		//	return Hash % Size;
		//}

		// Метод сложения строк с умножением на константу в степени
		private long HashFunction(string login)
		{
			int Key = 0;
			string fd = "";
			for (int i = 0; i < login.Length; i++)
			{
				Key += login[i];
				fd = fd + " + " + (int)login[i];
			}
			_OriginFrame.AddLog(fd);
			Key = Key * Key;
			_OriginFrame.AddLog(Key.ToString());
			Key = Key >> 10; // Отбрасываем справа 10 младших битов
			_OriginFrame.AddLog(Key.ToString());
			Key = Key % 4096; // Берем серединные 12 битов. Старшие 10 уходят в небытие
			_OriginFrame.AddLog(Key.ToString());

			return Key % Size;
		}

		private long LinearProbing(long hash)
		{
			if (hash == Size - 1)
				return 0;
			return ++hash;
		}

		public bool Add(PlayerInformation info)
		{
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Добавление нового пользователя " + info.Login + ".");
			long Key = HashFunction(info.Login);
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Первичный ключ - " + Key);
			if (_Hash[Key] != null && _Hash[Key].Login == info.Login)
			{
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Попытка добавить уже существующего пользователя!");
				return false;
			}

			while (_Hash[Key] != null || _DeletedElementFlags[Key] == true)
			{
				Key = LinearProbing(Key);
				if (_Hash[Key] != null && _Hash[Key].Login == info.Login)
				{
					_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Попытка добавить уже существующего пользователя!");
					return false;
				}
			}

			_Hash[Key] = info;
			_CountWithDeletedElements++;
			Count++;

			_ResizeHashIfItsNecessary();
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Добавлен новый элемент: логин - " + info.Login + ", возраст - " + info.Age + ", вторичный ключ: " + Key);
			_OriginFrame.AddLog(GetInfo());
			return true;
		}

		private bool Add(PlayerInformation info, bool internalAdditing = false)
		{
			long Key = HashFunction(info.Login);
			if (_Hash[Key] != null && _Hash[Key].Login == info.Login) // Эти данные уже есть в таблице
				return false;

			while (_Hash[Key] != null || _DeletedElementFlags[Key] == true)
			{
				Key = LinearProbing(Key);
				if (_Hash[Key] != null && _Hash[Key].Login == info.Login) // Эти данные уже есть в таблице
					return false;
			}

			_Hash[Key] = info;

			if (!internalAdditing)
			{
				_ResizeHashIfItsNecessary();
				_CountWithDeletedElements++;
				Count++;
			}
			return true;
		}

		public bool Remove(PlayerInformation info)
		{
			long Key = HashFunction(info.Login);
			if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
            {
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент для удаления не найден!");
				return false;
			}

			while (_DeletedElementFlags[Key] == true || _Hash[Key].Age != info.Age && _Hash[Key].Login != info.Login)
			{
				Key = LinearProbing(Key);
				if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
				{
					_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент для удаления не найден!");
					return false;
				}
			}

			_Hash[Key] = null;
			_DeletedElementFlags[Key] = true;
			Count--;

			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Был удален элемент " + info.Login + " c хэшем " + Key);
			_OriginFrame.AddLog(GetInfo());
			_ResizeHashIfItsNecessary();
			return true;
		}

		public PlayerInformation Find(PlayerInformation info)
		{
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Совершается поиск по хэш-таблице");
			int Comparsions = 0;

			long Key = HashFunction(info.Login);
			if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
			{
				Comparsions++;
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент не найден. Количество сравнений: " + Comparsions);
				return null;
			}

			Comparsions++;
			while (_DeletedElementFlags[Key] == true || _Hash[Key].Age != info.Age && _Hash[Key].Login != info.Login)
			{
				Comparsions++;
				Key = LinearProbing(Key);
				if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
				{
					_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент не найден. Количество сравнений: " + Comparsions);
					return null;
				}
			}
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент найден. Количество сравнений: " + Comparsions);
			return _Hash[Key];
		}

		public PlayerInformation FindByLogin(PlayerInformation info)
		{
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Совершается поиск по хэш-таблице");
			int Comparsions = 0;

			long Key = HashFunction(info.Login);
			if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
			{
				Comparsions++;
				_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент не найден. Количество сравнений: " + Comparsions);
				return null;
			}

			Comparsions++;
			while (_DeletedElementFlags[Key] == true || _Hash[Key].Login != info.Login)
			{
				Comparsions++;
				Key = LinearProbing(Key);
				if (_Hash[Key] == null && _DeletedElementFlags[Key] == false)
				{
					_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент не найден. Количество сравнений: " + Comparsions);
					return null;
				}
			}
			_OriginFrame.AddLog("[Хэш - Игроки-Возраст] Элемент найден. Количество сравнений: " + Comparsions);
			return _Hash[Key];
		}

		public List<PlayerInformation> FindByAgesInterval(int from, int to)
        {
			List<PlayerInformation> Result = new List<PlayerInformation>();
			for (int i = 0; i < Size; i++)
            {
				if (_Hash[i] != null && _Hash[i].Age >= from && _Hash[i].Age <= to)
					Result.Add(_Hash[i]);
            }

			return Result;
        }

		public string GetInfo()
		{
			string info = "";

			for (int i = 0; i < Size; i++)
			{
				if (_Hash[i] != null)
					info += i + ": " + _Hash[i].Login + " " + _Hash[i].Age + "\n";
			}

			info += "Total hash size: " + Size;
			return info;
		}

		public void Clear()
		{
			Size = 1;
			Count = 0;
			_Hash = new PlayerInformation[1];
			_DeletedElementFlags = new bool[1];
			_CountWithDeletedElements = 0;
		}

		public PlayerInformation this[int index]
		{
			get
			{
				return _Hash[index];
			}
		}
	}
}
