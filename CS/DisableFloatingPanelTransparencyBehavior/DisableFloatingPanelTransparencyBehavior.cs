using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using DevExpress.Xpf.Docking;
using System.Windows;

namespace DisableFloatingPanelTransparencyBehavior
{
	public class DisableFloatingPanelTransparencyBehavior: Behavior<DockLayoutManager>
	{
		private ResourceDictionary floatPaneStyles;
		protected override void OnAttached()
		{
			base.OnAttached();
			AssociatedObject.SetValue(DockLayoutManager.AllowFloatGroupTransparencyProperty, false);
			floatPaneStyles = new ResourceDictionary();
			floatPaneStyles.Source = new Uri(@"pack://application:,,,/DisableFloatingPanelTransparencyBehavior;component/themes/floatpane.xaml");			
			AssociatedObject.Resources.MergedDictionaries.Add(floatPaneStyles);
		}

		protected override void OnDetaching()
		{
			AssociatedObject.Resources.MergedDictionaries.Remove(floatPaneStyles);
			base.OnDetaching();
		}
	}
}
