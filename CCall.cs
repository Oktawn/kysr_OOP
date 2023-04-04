using System;

namespace Ccall
{
    class CCall
    {
        private bool priority;
        private string thems;
        private string abonent;
        private string numbers;
        private readonly double start_timer;

        public CCall()
        {
            priority = false;
            thems = "programming";
            abonent = "chel";
            numbers = "+79XXXXXXXXX";
            start_timer = DateTime.Now.Second;
        }
        public CCall(bool priority, string thems, string numbers, string abonent)
        {
            Priority = priority;
            Abonent = thems;
            Thems = abonent;
            Numbers = numbers;
        }
        public CCall(CCall C)
        {
            thems = C.thems;
            priority = C.priority;
            abonent = C.abonent;
            numbers = C.numbers;
            start_timer = C.start_timer;
        }


        public bool Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string Abonent
        {
            get { return abonent; }
            set { abonent = value; }
        }
        public string Thems
        {
            get { return thems; }
            set { thems = value; }
        }
        public string Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public double Start_timer
        { get { return start_timer; } }

        public bool set_string(string t)
        {
            foreach (var item in t)
            {
                if (char.IsLetter(item))
                    continue;
                else
                    return false;
            }
            return true;
        }
        public bool set_number(string t)
        {
            if (t.Length != 12)
                return false;
            foreach (var item in t)
            {
                if (char.IsDigit(item))
                    continue;
                else
                    return false;
            }
            return true;
        }
        public bool set_priority(string t)
        {
            if (t == "False") return false;
            return true;
        }

        public string get_all()
        {
            return Priority.ToString() + Environment.NewLine
                + Abonent + Environment.NewLine
                + Thems + Environment.NewLine
                + Numbers + Environment.NewLine;
        }

        public double duration_time => Convert.ToDouble(DateTime.Now.Second - Start_timer);
    }
}


