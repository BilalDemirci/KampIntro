namespace DictionaryHomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> kullanicilar = new MyDictionary<int,string>();
            kullanicilar.Add(0, "Bilal");
            kullanicilar.Add(1, "Aybüke");

            int[] keys = kullanicilar.keys;
            string[] values = kullanicilar.values;

            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }


            Console.ReadLine();
        }
    }

    public class MyDictionary<Key, Value>
    {
        Key[] _key;
        Value[] _value;

        public MyDictionary()
        {
            _key = new Key[0];
            _value = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempkey = _key;
            Value[] tempValue = _value;

            _key = new Key[_key.Length + 1];
            _value = new Value[_key.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                _key[i] = tempkey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                _value[i] = tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }



        public Key[] keys
        {
            get { return _key; }
        }

        public Value[] values
        {
            get { return _value; }
        }

    }
}
