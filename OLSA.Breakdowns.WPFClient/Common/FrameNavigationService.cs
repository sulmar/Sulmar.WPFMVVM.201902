using OLSA.Breakdowns.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OLSA.Breakdowns.WPFClient.Common
{
    public class FrameNavigationService : INavigationService
    {
        public object Parameter => throw new NotImplementedException();

        public void GoBack()
        {
            Frame frame = Get("ViewFrame");

            frame.GoBack();
        }

        public void GoForward()
        {
            Frame frame = Get("ViewFrame");

            frame.GoForward();
        }

        public void Navigate(string viewName, object parameter = null)
        {
            Frame frame = Get("ViewFrame"); // TODO: find frame

            Uri uri = new Uri($"Views/{viewName}.xaml", UriKind.Relative);

            frame.Navigate(uri, parameter);
        }

        private Frame Get(string name)
        {            

            if (Application.Current.MainWindow.FindName(name) is Frame frame)
            {
                return frame;
            }

            throw new KeyNotFoundException(name);
        }
    }
}
