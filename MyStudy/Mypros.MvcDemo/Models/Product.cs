using System;
using System.ComponentModel.DataAnnotations;

namespace Mypros.MvcDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string BookName { get; set; }
       public string Title { get; set; }
       public string Link { get; set; }

       public int Comment { get; set; }

       public decimal Price { get; set; }


       
    }
}