using EmployeeManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeManager.Components
{
    /// <summary>
    /// Interaction logic for AddEmployeePopup.xaml
    /// </summary>
    public partial class AddEmployeePopup : UserControl
    {
        private double _popupX = 100, _popupY = 100; // Initial popup position

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(AddEmployeePopup), new PropertyMetadata(false));


        public AddEmployeePopup()
        {
            InitializeComponent();
            DataContext = new AddEmployeeViewModel();
        }

        private void DragThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            _popupX += e.HorizontalChange;
            _popupY += e.VerticalChange;

            DraggablePopup.HorizontalOffset = _popupX;
            DraggablePopup.VerticalOffset = _popupY;
        }
    }
}
