using LodIssue.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls.ListView;

namespace LodIssue.ViewModels
{
    public class ListPageViewModel
    {
        //public List<Item> Source { get; set; }
        public ListViewLoadOnDemandCollection Source { get; set; }
        private int lodTriggerCount = 0;

        public ListPageViewModel()
        {
            //this.Source = new List<Item> { new Item("Tom"), new Item("Anna"), new Item("Peter"), new Item("Teodor"), new Item("Lorenzo"), new Item("Andrea"), new Item("Martin") };
            this.Source = new ListViewLoadOnDemandCollection((cancelationToken) =>
            {
                List<string> result = new List<string>();

                try
                {
                    //simulates connection latency
                    Task.Delay(1000, cancelationToken).Wait();

                    this.lodTriggerCount++;
                    foreach (string item in Enum.GetNames(typeof(DayOfWeek)))
                    {
                        result.Add(string.Format("LOD: {0} - {1}", lodTriggerCount, item));
                    }
                    return result;
                }
                catch
                {
                    //exception is thrown when the task is canceled. Returning null does not affect the ItemsSource.
                    return null;
                }
            });

           /* for (int i = 0; i < 14; i++)
            {
                Source.Add(string.Format("Item {0}", i));
            }*/
        }
    }
}
