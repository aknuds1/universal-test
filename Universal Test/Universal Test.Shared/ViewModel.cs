using System;
using System.Collections.Generic;
using System.Text;

namespace Universal_Test
{
    class ItemModel
    {
        public ItemModel(string name, string date, string description)
        {
            Name = name;
            Date = date;
            Description = description;
        }

        public string Name { get; set; }
        public string Date {  get; set; }
        public string Description { get; set; }
    }

    class ViewModel
    {
        private IList<ItemModel> _itemModels;

        public IList<ItemModel> ItemModels
        {
            get
            {
                return _itemModels ?? (_itemModels = new List<ItemModel>
                {
                    new ItemModel("Item 1", "25.04.2014", "Description 1"),
                    new ItemModel("Item 2", "25.04.2014", "Description 2")
                });
            }
            set
            {
                _itemModels = value;
            }
        }
    }
}
