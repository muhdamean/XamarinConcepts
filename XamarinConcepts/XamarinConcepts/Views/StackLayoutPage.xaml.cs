using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinConcepts.Models;

namespace XamarinConcepts.Views
{
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
            MyItems = GetItems();
            this.BindingContext = this;
        }

        public List<Item> MyItems { get; set; }

        private List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Id="1", Text="First Item", Description="This is an item description"},
                new Item { Id="2", Text="Second Item", Description="This is an item description"},
                new Item { Id="3", Text="Third Item", Description="This is an item description"},
                new Item { Id="4", Text="Fourth Item", Description="This is an item description"},
                new Item { Id="5", Text="Fifth Item", Description="This is an item description"},
                new Item { Id="6", Text="Sixth Item", Description="This is an item description"},
                new Item { Id="7", Text="Seventh Item", Description="This is an item description"},
                new Item { Id="8", Text="Eigth Item", Description="This is an item description"},
                new Item { Id="9", Text="Ninth Item", Description="This is an item description"},
                new Item { Id="10", Text="Tenth Item", Description="This is an item description"},
                new Item { Id="11", Text="Eleventh Item", Description="This is an item description"},
                new Item { Id="12", Text="Twelveth Item", Description="This is an item description"},
                new Item { Id="13", Text="Thirteent Item", Description="This is an item description"},
                new Item { Id="14", Text="Fourteent Item", Description="This is an item description"},
                new Item { Id="15", Text="Fifteent Item", Description="This is an item description"},
            };
        }
    }
}

