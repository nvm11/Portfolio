//Nathan McAndrew
//12/10/22
//Program to show understanding of Binary File I/O
//as well as dictionaries. Reads and Writes a phonebook
namespace WorkWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phonebook = new Dictionary<string, int>();
        }
        /// <summary>
        /// saves the user's input to a phone book file
        /// </summary>
        /// <exception cref="Exception">any exception that occurs during file writing process</exception>
        public void Save(Dictionary<string, int> phonebook)
        {
            FileStream OutStream = File.OpenWrite("../../../phonebook.data");
            BinaryWriter output = null!;
            try
            {
                output = new BinaryWriter(OutStream);
                //first writes how many times to iterate
                output.Write(phonebook.Count);

                //writes entire dict to the file
                foreach (KeyValuePair<string, int> entry in phonebook)
                {
                    output.Write(entry.Key);
                    output.Write(entry.Value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error saving to file");
            }
            finally
            {
                //occurs only if file was opened
                if (output != null)
                {
                    output.Close();
                }
            }
        }

        /// <summary>
        /// Reads data from file back into program
        /// </summary>
        public Dictionary<string, int> Load(Dictionary<string, int> phonebook)
        {
            phonebook.Clear();
            FileStream InStream = File.OpenRead("../../../phonebook.data");
            BinaryReader input = null!;

            try
            {
                phonebook = new Dictionary<string, int>();
                input = new BinaryReader(InStream);

                for (int i = 0; i < input.ReadInt32(); i++)
                {
                    //adds key value pairs to dictionary
                    phonebook.Add(input.ReadString(), input.ReadInt32());
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error loading data from file");
            }
            finally
            {
                if (input != null!)
                {
                    input.Close();
                }
            }
            return phonebook;
        }
        /// <summary>
        /// prints out the phone book
        /// </summary>
        /// <param name="phonebook">dictionary with names and numbers</param>
        public void Print(Dictionary<string, int> phonebook)
        {
            foreach(KeyValuePair<string, int> entry in phonebook)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}