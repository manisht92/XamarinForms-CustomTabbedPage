using System;
using Xamarin.Forms;

namespace Demo1.Controls
{
    public class MaterialFrame : Frame
    {
        public static BindableProperty ElevationProperty = BindableProperty.Create(nameof(Elevation), typeof(float), typeof(MaterialFrame), 4.0f);

        public float Elevation
        {
            get
            {
                return (float)GetValue(ElevationProperty);
            }
            set
            {
                SetValue(ElevationProperty, value);
            }
        }

        public static BindableProperty ShadowOpacityProperty = BindableProperty.Create("ShadowOpacity", typeof(float), typeof(MaterialFrame), 0.8f);

        public float ShadowOpacity
        {
            get
            {
                return (float)GetValue(ShadowOpacityProperty);
            }
            set
            {
                SetValue(ShadowOpacityProperty, value);
            }
        }
    }
}
