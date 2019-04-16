using BlankApp1.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<TestModel> TestList { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            TestList = new ObservableCollection<TestModel>()
            {
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"},
                new TestModel(){Name = "Try"}
            };

        }
    }
}
