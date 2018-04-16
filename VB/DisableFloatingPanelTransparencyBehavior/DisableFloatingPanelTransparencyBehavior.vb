Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Interactivity
Imports DevExpress.Xpf.Docking
Imports System.Windows

Namespace DisableFloatingPanelTransparencyBehavior
	Public Class DisableFloatingPanelTransparencyBehavior
		Inherits Behavior(Of DockLayoutManager)
		Private floatPaneStyles As ResourceDictionary
		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			AssociatedObject.SetValue(DockLayoutManager.AllowFloatGroupTransparencyProperty, False)
			floatPaneStyles = New ResourceDictionary()
			floatPaneStyles.Source = New Uri("pack://application:,,,/DisableFloatingPanelTransparencyBehavior;component/themes/floatpane.xaml")
			AssociatedObject.Resources.MergedDictionaries.Add(floatPaneStyles)
		End Sub

		Protected Overrides Sub OnDetaching()
			AssociatedObject.Resources.MergedDictionaries.Remove(floatPaneStyles)
			MyBase.OnDetaching()
		End Sub
	End Class
End Namespace
