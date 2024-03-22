using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClicks.DataTemplateSelectors
{
    public class CollectionDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EmptyDataTemplate { get; set; }

        public DataTemplate RealDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is RealItem)
            {
                return RealDataTemplate;
            }

            return EmptyDataTemplate;
        }
    }
}
