

using System;
using System.ComponentModel.DataAnnotations;

namespace ICONEXT.Models
{
    public class employee
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public string Position { get; set; }

        public string Active { get; set; }
    }
}