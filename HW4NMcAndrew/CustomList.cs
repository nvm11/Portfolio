//Nathan McAndrew
//10/19/22
//Contains numerous methods and properties
//to allow an array to mimic a list

namespace HW4NMcAndrew
{

    internal class CustomList<T>
    {
        private T[] data;
        private int count;

        /// <summary>
        /// Creates an array with default capacity of 4
        /// </summary>
        public CustomList() : this(4) { }

        /// <summary>
        /// Creates an array of the specified size
        /// </summary>
        /// <param name="capacity">length of the array</param>
        public CustomList(int capacity)
        {
            count = 0;
            data = new T[capacity];
        }

        /// <summary>
        /// Gets the length of array in use
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Gets the length of the entire array
        /// </summary>
        public int Capacity { get { return data.Length; } }

        /// <summary>
        /// Gets the information at the specified index
        /// Sets an index equal to the parameter
        /// </summary>
        /// <param name="index">index to return/change</param>
        /// <returns>the information contained within the specified
        /// index</returns>
        public T this[int index]
        {
            get
            {
                if (IndexIsValid(index))
                {
                    return data[index];
                }
                else
                {
                    return default;
                }
            }

            set
            {
                if (IndexIsValid(index))
                {
                    data[index] = value;
                }
            }
        }

        /// <summary>
        /// prints the portion of the array in use
        /// </summary>
        public void Print()
        { 
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        /// <summary>
        /// adds an item into the array
        /// </summary>
        /// <param name="item">object to be added</param>
        public void Add(T item)
        {
            //prevents out of bounds
            if (count >= Capacity)
            {
                data = TransferData(data);
            }
            data[count] = item;
            count++;

        }

        /// <summary>
        /// Generates a larger array when the user
        /// desires more indecies than the capacity
        /// </summary>
        /// <param name="smallArray">the original array to be copied</param>
        /// <returns>the original array address pointing
        /// to a larger array</returns>
        private T[] TransferData(T[] smallArray)
        {
            T[] newData = new T[smallArray.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newData[i] = smallArray[i];
            }
            return newData;
        }

        /// <summary>
        /// obtains the index of an item in the list
        /// </summary>
        /// <param name="item">item to search for</param>
        /// <returns>index of the item if found, -1 otherwise</returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Checks if a value is true
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remves a value at the specified index
        /// </summary>
        /// <param name="index">index to remove</param>
        public void RemoveAt(int index)
        { 
            data = ReIndex(-1, index);
        }
        
        /// <summary>
        /// Removes the specified value
        /// </summary>
        /// <param name="item">value to be removed</param>
        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (data[i].Equals(item))
                {
                    data = ReIndex(-1, i);
                }
                
            }
        }

        /// <summary>
        /// inserts a value at the specified index
        /// </summary>
        /// <param name="index">index a value is inserted at</param>
        /// <param name="item">value inserted</param>
        public void Insert(int index, T item)
        {
            //checks for run time error
            if (Count.Equals(Capacity))
            {
                data = TransferData(data);
            }

            data = ReIndex(1, index);
            data[index] = item;
        }

        /// <summary>
        /// reorganizes a list, either making it
        /// one index smaller or larger
        /// </summary>
        /// <param name="sign">-1 for losing an index,
        /// 1 for gaining an index</param>
        /// <param name="index">the index lost or gained</param>
        /// <returns>the modified array/list</returns>
        private T[] ReIndex(int sign,int index)
        {
            //checks to see if out of bounds
            //error will occur
            if ((count + sign) > Capacity)
            {
                data = TransferData(data);
            }

            T[] newData = new T[data.Length];
            for (int i = 0; i <= index; i++)
            {
                newData[i] = data[i];
                for (int j = index + (-1 * sign); j < count; j++)
                {
                    //will skip in the event j is not a valid index
                    if (IndexIsValid(j))
                    {
                        newData[j + sign] = data[j];
                    }
                }
            }

            count += sign;
            return newData;
        }

        /// <summary>
        /// sets each index in a list
        /// equal to the datatype's default
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                data[i] = default;
            }
        }

        /// <summary>
        /// Checks if an index is within the count
        /// </summary>
        /// <param name="index">index to check</param>
        /// <returns>true if it is valid, false otherwise</returns>
        public bool IndexIsValid(int index)
        {
            if (index >= 0 && index < Count)
            {
                return true;
            }
            return false;
        }
    }

}
