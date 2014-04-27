using System;
using System.Collections.Generic;
using System.Text;

namespace Universal_Test
{
    class ItemModel
    {
        public ItemModel(string name, string date, string description, Uri itemUri)
        {
            Name = name;
            Date = date;
            Description = description;
            ItemUri = itemUri;
        }

        public string Name { get; set; }
        public string Date {  get; set; }
        public string Description { get; set; }
        public Uri ItemUri { get; set; }
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
                    new ItemModel("Item 1", "25.04.2014", "Description 1", new Uri("http://example.com")),
                    new ItemModel("Item 2", "25.04.2014", "Description 2", new Uri("http://example.com")),
                    new ItemModel("Item 3", "26.04.2014", "Description 3", new Uri("http://example.com"))
                });
            }
            set
            {
                _itemModels = value;
            }
        }
    }
}
