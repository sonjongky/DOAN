using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Item
    {
        //Fields
        private string _id_item;
        private int _id_category;
        private string _name;
        private int _price;
        private Image _photo;

        // Properties
        public string ID_Item
        {
            get { return _id_item; }
            set { _id_item = value; }
        }
        public int ID_Category
        {
            get { return _id_category; }
            set { _id_category = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
    }
}
