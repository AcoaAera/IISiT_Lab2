using System;

namespace Tests_Project__Lab_1_
{
    struct Fact
    {
        public Fact(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name // название факта
        {
            get;
            set;
        }

        public string Value // значение факта { да, нет, значение NULL и т.д. } 
        {
            get;
            set;
        }
    }
}
