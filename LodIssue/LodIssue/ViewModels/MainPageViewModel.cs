using LodIssue.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LodIssue.ViewModels
{
    public class MainPageViewModel
    {
        
        //public List<Item> Source { get; set; }
        private ListPageViewModel _listViewModel;

        public ListPageViewModel listViewModel
        {
            get { return _listViewModel; }
            set { _listViewModel = value; }
        }

        public MainPageViewModel()
        {
            _listViewModel = new ListPageViewModel();
            //this.Source = new List<Item> { new Item("Tom"), new Item("Anna"), new Item("Peter"), new Item("Teodor"), new Item("Lorenzo"), new Item("Andrea"), new Item("Martin") };

        }
    }
}
