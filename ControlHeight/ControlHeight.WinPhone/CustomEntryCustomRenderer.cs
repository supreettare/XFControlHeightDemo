using ControlHeight.WinPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryCustomRenderer))]
namespace ControlHeight.WinPhone
{
    public class CustomEntryCustomRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Element != null)
            {
                var t = Element as Entry; 
            }
        }
    }
}
