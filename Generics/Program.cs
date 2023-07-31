namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Hatay2");
            sehirler.Add("Hatay3");
            sehirler.Add("Hatay4");
            sehirler.Add("Hatay5");
            sehirler.Add("Hatay6");

            sehirler[0] = "İst";// set
            Console.WriteLine(sehirler[0]);// get
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara2");
            sehirler2.Add("Ankara34");
            sehirler2.Add("Ankara45");
            sehirler2.Add("Ankara6");
            sehirler2.Add("Ankara7");
            sehirler2.Add("Ankara8");
            sehirler2.Add("Ankara9");

            sehirler2[0] = "İst";// Indexing
            Console.WriteLine(sehirler2.Count);
            //Console.WriteLine(sehirler2[0]);// get

            foreach (string sehir in sehirler2.Items)
            {
                Console.WriteLine(sehir);
            }
        }
    }

    class MyList<T>// T = Type, Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)// Burada bulunan T listeyi oluştururken hangi değeri verirsek o değeri alır.(string, int vs)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _array.Length; }
            //set { _count = value; }
        }

        public T[] Items
        {
            get
            {
                return _array;
            }
        }

        public T this[int index]// Indexer
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

    }
}