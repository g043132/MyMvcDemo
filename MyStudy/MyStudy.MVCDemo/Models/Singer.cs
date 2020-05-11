using System;
using System.ComponentModel.DataAnnotations;

namespace MyStudy.MVCDemo.Models
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public string Url { get; set; }
    }
}