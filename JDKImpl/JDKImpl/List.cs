namespace JDKImpl
{
    public interface IList<T>
    {
        void Add(T args);

        T Get(int index);

        T Get(T args);

        void Remove(int index);

        void Remove(T args);
    }
    public class ArrayList<T> : IList<T>
    {

        private T[] buffer = new T[10000];
        private T[] backup;

        private int index = 0;

        public ArrayList() { }

        public void Add(T args)
        {
            if (index == buffer.Length - 1)
            {
                Backup(buffer, buffer.Length * 2);
            }
            if (backup != null && index == backup.Length - 1)
            {
                Reset(backup, backup.Length * 2);
            }
            buffer[index] = args;
            index++;
        }

        public T Get(int index)
        {
            return buffer[index];
        }

        public T Get(T args)
        {
            foreach (object element in buffer)
            {
                if (element == (object) args)
                {
                    return (T) element;
                }
            }
            return default;
        }

        public void Remove(int index)
        {
            buffer[index] = default;
        }

        public void Remove(T args)
        {
            int inc = 0;
            foreach (object element in buffer)
            {
                if (element == (object) args)
                {
                    buffer[index] = default;
                    break;
                }
                inc++;
            }
            index--;
        }

        private void Backup(T[] old, int size)
        {
            backup = new T[size];
            for (int i = 0; i < old.Length - 1; i++)
            {
                backup[i] = buffer[i];
                buffer[i] = default;
            }
        }

        private void Reset(T[] current, int size)
        {
            buffer = new T[size];
            for (int i = 0; i < current.Length - 1; i++)
            {
                buffer[i] = backup[i];
                backup[i] = default;
            }
        }
    }
}
