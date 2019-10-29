using LodIssue.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LodIssue.ViewModels
{
    public class MasterPageViewModel
    {

        //public List<Item> Source { get; set; }
        private MainPageViewModel _mainPageViewModel;

        public MainPageViewModel MainPageViewModel
        {
            get { return _mainPageViewModel; }
            set { _mainPageViewModel = value; }
        }

        public MasterPageViewModel()
        {
            _mainPageViewModel = new MainPageViewModel();
            //this.Source = new List<Item> { new Item("Tom"), new Item("Anna"), new Item("Peter"), new Item("Teodor"), new Item("Lorenzo"), new Item("Andrea"), new Item("Martin") };

        }
    }
}
