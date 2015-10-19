using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlHeight
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            //var t = entryDefault.Height.ToString(); 
            InitializeComponent();
        }

        public override SizeRequest GetSizeRequest(double widthConstraint, double heightConstraint)
        {
            txtLabel.Text = entryDefault.Height.ToString(); 

            return base.GetSizeRequest(widthConstraint, heightConstraint);
        }

        protected override void OnChildAdded(Element child)
        {  
            //var t  = entryDefault.Height.ToString(); 
            base.OnChildAdded(child);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            var t = entryDefault.Height.ToString(); 
            base.OnSizeAllocated(width, height);
        }

        protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
        {
            var t = entryDefault.Height.ToString(); 
            return base.OnSizeRequest(widthConstraint, heightConstraint);
        }
    }
}
