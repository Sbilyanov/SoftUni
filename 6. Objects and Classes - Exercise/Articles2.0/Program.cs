using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articles> articles = new List<Articles>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Articles article = new Articles(input[0], input[1], input[2]);
                articles.Add(article);
            }
            string criteria = Console.ReadLine();
            switch (criteria)
            { 
                case "title":
                    articles = articles.OrderBy(n =>n.Title).ToList();
                    break;
                    
                case "content":
                    articles = articles.OrderBy(n => n.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(n => n.Author).ToList();
                    break;
           
            }
            Console.WriteLine(string.Join(Environment.NewLine,articles));

        }
    }
    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

      
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
