using System;
using System.ComponentModel;
using CoreGraphics;
using Demo1.Controls;
using Demo1.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MaterialFrame), typeof(MaterialFrameRenderer))]
namespace Demo1.iOS.Renderers
{
    public class MaterialFrameRenderer : FrameRenderer
    {
        public static void Initialize()
        {
            // empty, but used for beating the linker
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;
            UpdateShadow();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "Elevation")
            {
                UpdateShadow();
            }
        }

        private void UpdateShadow()
        {

            //var materialFrame = (MaterialFrame)Element;

            // Update shadow to match better material design standards of elevation
            //Layer.ShadowRadius = materialFrame.Elevation;

            //Layer.BorderWidth = 0.1f;
            //Layer.BorderColor = UIColor.LightGray.CGColor;

            //Layer.ShadowColor = UIColor.Gray.CGColor;
            //Layer.ShadowOffset = new CGSize(2, 2);
            //Layer.ShadowOpacity = 0.80f;
            //Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
            //Layer.MasksToBounds = false;
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            var materialFrame = (MaterialFrame)Element;
            // Update shadow to match better material design standards of elevation
            //Layer.CornerRadius = materialFrame.CornerRadius;
            //Layer.BorderWidth = 0.1f;
            Layer.BorderColor = UIColor.LightGray.CGColor;
            Layer.ShadowRadius = materialFrame.Elevation;
            Layer.ShadowColor = UIColor.Gray.CGColor;
            Layer.ShadowOffset = new CGSize(2, 2);
            Layer.ShadowOpacity = materialFrame.ShadowOpacity;
            Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
            Layer.MasksToBounds = false;
        }
    }
}
