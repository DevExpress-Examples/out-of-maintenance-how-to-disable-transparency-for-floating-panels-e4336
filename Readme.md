<!-- default file list -->
*Files to look at*:

* [DisableFloatingPanelTransparencyBehavior.cs](./CS/DisableFloatingPanelTransparencyBehavior/DisableFloatingPanelTransparencyBehavior.cs) (VB: [DisableFloatingPanelTransparencyBehavior.vb](./VB/DisableFloatingPanelTransparencyBehavior/DisableFloatingPanelTransparencyBehavior.vb))
* [FloatPane.xaml](./CS/DisableFloatingPanelTransparencyBehavior/Themes/FloatPane.xaml) (VB: [FloatPane.xaml](./VB/DisableFloatingPanelTransparencyBehavior/Themes/FloatPane.xaml))
* [MainWindow.xaml](./CS/WpfApplication54/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication54/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication54/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication54/MainWindow.xaml))
<!-- default file list end -->
# How to disable transparency for floating panels


<p>Floating panels are designed to have transparent elements.  To disable transparency, do the following:</p><p><br />
1) Deactivate the DockLayoutManager's AllowFloatGroupTransparency option.</p><p>2) Modify the built-in styles and templates that define floating panels' appearance and remove transparent elements. The following styles and templates should be modified:<br />
</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=EmptyBorderTemplate}"</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=FormBorderTemplate}"</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=SingleBorderTemplate}"</p><p>- "{dxt:DocumentPaneElementsThemeKey ResourceKey=MDIDocument}"</p><p>- Style for the "ve:ResizeBoundsControl" type.<br />
</p><p>This example illustrates how to modify these resources. The necessary functionality is implemented in the DisableFloatingPanelTransparencyBehavior attached behavior class.</p>

<br/>


