using System;
using System.Collections;
using System.Text;
using System.Xml.Linq;

namespace Day4.Encapsulation
{
    internal struct PhoneNotebook : IEnumerable
    {
        #region Prop
        public string[]? Names { get; set; }
        public int[]? Numbers { get; set; }
        public int Size { get; set; }
        #endregion

        #region ctor
        public PhoneNotebook(string[]? names, int[]? numbers, int size)
        {
            Names = names;
            Numbers = numbers;
            Size = size;
       
        }
        public PhoneNotebook(int size)
        {
            Size = size;
            Names = new string[Size];
            Numbers = new int[Size];
        }
        #endregion
        public void AddPerson(int position, string name, int number)
        {
            if(Names is not null && Numbers is not null)
            {
                if( position < Size && position >= 0)
                {
                    Names[position] = name;
                    Numbers[position] = number;
                }
                else
                {
                    Console.WriteLine("invalid position");
                    return;
                }
            }
        }


        //public void SetNumber(string name, int newNumber)
        //{
        //    for (int i = 0; i < Size; i++)
        //    {
        //        if(name == Names?[i])
        //        {
        //            Numbers?[i] = newNumber;
        //            return;
        //        }
        //    }
        //}
        //public void SetName(int number, string newname)
        //{
        //    for (int i = 0; i < Size; i++)
        //    {
        //        if(name == Names?[i])
        //        {
        //            Numbers?[i] = newNumber;
        //            return;
        //        }
        //    }
        //}


        #region Indexer
        //set number //send name[]

        //note02["Ahmed"]
        //note02[9999]
        public int this[string name] {
            get
            {
                for (int i = 0; i < Size; i++)
                {
                    if (name == Names?[i])
                    {
                        return Numbers?[i] ?? -1;
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < Size; i++)
                {
                    if (name == Names?[i])
                    {
                        Numbers?[i] = value;
                        return;
                    }
                }
            }
        }

        //public string this[int number]
        //{
        //    get
        //    {
        //        for (int i = 0; i < Size; i++)
        //        {
        //            if (number == Numbers?[i])
        //            {
        //                return Names?[i] ?? "";
        //            }
        //        }
        //        return "";
        //    }
        //    set
        //    {

        //        for (int i = 0; i < Size; i++)
        //        {
        //            if (number == Numbers?[i])
        //            {
        //                Names?[i] = value;
        //                return;
        //            }
        //        }

        //    }

        //}

        public string this[int index]
        {
            get { return "position: " + index + ", name: " + Names[index] + ", number: " + Numbers[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                yield return $"Name : {Names?[i]}, Number{Numbers?[i]}";
            }

        }
        #endregion
    }
}
