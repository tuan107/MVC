using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class Item
    {
        int id;
        string img;
        string ten;
        
        public int Id { get => id; set => id = value; }
        public string Img { get => img; set => img = value; }
        public string Ten { get => ten; set => ten = value; }
        public List<Item> list;
        public void getData()
        {
            list = DAL.DALItem.getSp();
        }
    }
}