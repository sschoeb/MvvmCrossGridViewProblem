using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;

namespace GridViewBug.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public FirstViewModel()
        {
            Items = new ObservableCollection<TestClass>();
            Items.Add(new TestClass { Name = "Test1" });
            Items.Add(new TestClass { Name = "Test2" });
        }

        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }

        public ObservableCollection<TestClass> Items { get; set; }
    }

    public class TestClass
    {
        public string Name { get; set; }
    }
}
