using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace EmployeeManager.Controls
{
    /// <summary>
    /// Interaction logic for CustomComboBox.xaml
    /// </summary>
    public partial class CustomComboBox : UserControl
    {
        public List<string> CustomItemsSource
        {
            get { return (List<string>)GetValue(ItemSourcesProperty); }
            set 
            { 
                SetValue(ItemSourcesProperty, value); 
            }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourcesProperty =
            DependencyProperty.Register("CustomItemsSource", typeof(List<string>), typeof(CustomComboBox), new PropertyMetadata(null));

        public string SelectedItem
        {
            get { return (string)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(string), typeof(CustomComboBox), new PropertyMetadata(null));

        public bool IsDropDownOpen { get; set; }
        
        public CustomComboBox()
        {
            InitializeComponent();
        }


    }
}
