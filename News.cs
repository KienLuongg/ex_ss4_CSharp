using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.ss4
{
    public class News : INew 
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;

        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverageRate { get => averageRate;}

        public void Display() 
        {
            Console.WriteLine(title);
            Console.WriteLine(publishDate);
            Console.WriteLine(author);
            Console.WriteLine(content);
            Console.WriteLine(averageRate);
        }

        int[] rateList = new int[3];

        public double calculate(int rate)
        {
            averageRate = (rateList[1] + rateList[2] + rateList[3]) / 3; 
            return averageRate;
        }
     }
}
