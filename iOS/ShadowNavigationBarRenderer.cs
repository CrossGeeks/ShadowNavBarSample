using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using ShadowNavBarSample.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(ShadowNavigationBarRenderer))]
namespace ShadowNavBarSample.iOS
{
	public class ShadowNavigationBarRenderer : NavigationRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (this.Element == null) return;

            NavigationBar.Layer.ShadowColor = UIColor.Gray.CGColor;
			NavigationBar.Layer.ShadowOffset = new CGSize(0, 0);
			NavigationBar.Layer.ShadowOpacity = 1;
		}
	}
}