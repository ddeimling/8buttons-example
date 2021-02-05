using EightButtonsExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EightButtonsExample.View.TemplateSelector
{
    public class ContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EightButtonsTemplate { get; set; }
        public DataTemplate ErrorTemplate { get; set; }
        public DataTemplate TemplateMissingTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IEightButtonsViewModel)
                return EightButtonsTemplate;

            if (item is IErrorViewModel)
                return ErrorTemplate;

            return TemplateMissingTemplate;
        }
    }
}
