using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoListDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public ObservableCollection<ToDo>ToDos { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private ToDo selectedToDo;

        public ToDo SelectedToDo
        {
            get { return selectedToDo; }
            set { selectedToDo = value; OnPropertyChanged(); }
        }

       

        public MainWindow()
        {
            InitializeComponent();

            ToDos=new ObservableCollection<ToDo>
            {
                new ToDo
                {
                    Id=1,
                    TaskName="Buy Grocery",
                    Status=TaskStatus.ToDo,
                },
                new ToDo
                {
                    Id=2,
                    TaskName="Send Email",
                    Status=TaskStatus.InProgress,
                },
                new ToDo
                {
                    Id=3,
                    TaskName="Finish Assigment",
                    Status=TaskStatus.Complete,
                },
                new ToDo
                {
                    Id=4,
                    TaskName="Bake Cake",
                    Status=TaskStatus.ToDo,
                },
                new ToDo
                {
                    Id=5,
                    TaskName="Write Blog Post",
                    Status=TaskStatus.InProgress,
                },
            };
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToDos.Add(new ToDo { 
            
               TaskName="Learn Word",
            
            });
            

        }

        private void mylistView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Window1 window = new Window1();
            window.ToDo = selectedToDo;
            window.Show();
        }
    }
}
