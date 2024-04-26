using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Classes
{
    public class Message
    {
        public DateTime date { get; set; }
        public string Title { get; set; }

        public Message(string title)
        {
            this.date = DateTime.Now;
            Title = title;
        }

        public override string ToString()
        {
            return $"{date.ToShortTimeString()}                {Title}";
        }
    }
}
