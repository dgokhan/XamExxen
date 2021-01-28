using Xamarin.Forms;

namespace XamExxen.Renderers
{
    public class CustomButton : Button
    {

        public static BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create<CustomButton, Xamarin.Forms.TextAlignment>(x => x.HorizontalTextAlignment, Xamarin.Forms.TextAlignment.Center);
        public Xamarin.Forms.TextAlignment HorizontalTextAlignment
        {
            get
            {
                return (Xamarin.Forms.TextAlignment)GetValue(HorizontalTextAlignmentProperty);
            }
            set
            {
                SetValue(HorizontalTextAlignmentProperty, value);
            }
        }


        public static BindableProperty VerticalTextAlignmentProperty = BindableProperty.Create<CustomButton, Xamarin.Forms.TextAlignment>(x => x.VerticalTextAlignment, Xamarin.Forms.TextAlignment.Center);
        public Xamarin.Forms.TextAlignment VerticalTextAlignment
        {
            get
            {
                return (Xamarin.Forms.TextAlignment)GetValue(VerticalTextAlignmentProperty);
            }
            set
            {
                SetValue(VerticalTextAlignmentProperty, value);
            }
        }
    }
}
