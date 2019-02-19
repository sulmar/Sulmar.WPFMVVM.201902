using System;
using System.Collections.Generic;
using System.Text;

namespace OLSA.Breakdowns.IServices
{
    public interface INavigationService
    {
        void Navigate(string viewName, object parameter = null);
        void GoForward();
        void GoBack();

        object Parameter { get; }

    }
}
