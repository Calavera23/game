using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millioner
{
    class Question
    {
        public string question;
        public string a1_right;
        public string a2;
        public string a3;
        public string a4;
        public Question() { }
        public Question(string question, string a1_right, string a2, string a3, string a4)
        {
            this.question = question;
            this.a1_right = a1_right;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
        }


    }
}
