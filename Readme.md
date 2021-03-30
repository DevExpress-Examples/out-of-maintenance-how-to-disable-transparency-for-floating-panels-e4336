# [Obsolete] How to disable transparency for floating panels

Please set the [DockLayoutManager.EnableWin32Compatibility](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.EnableWin32Compatibility) property to `true` to disable transparency in floating panels and make it possible to display Windows Forms controls.


<details>
  <summary>The legacy solution</summary>
  
Floating panels are designed to have transparent elements. To disable transparency, do the following:
1) Deactivate the DockLayoutManager's `AllowFloatGroupTransparency` option.
2) Modify the built-in styles and templates that define floating panels' appearance and remove transparent elements. The following styles and templates should be modified:<br />
- `"{dxt:FloatPaneElementsThemeKey ResourceKey=EmptyBorderTemplate}"`
- `"{dxt:FloatPaneElementsThemeKey ResourceKey=FormBorderTemplate}"`
- `"{dxt:FloatPaneElementsThemeKey ResourceKey=SingleBorderTemplate}"`
- `"{dxt:DocumentPaneElementsThemeKey ResourceKey=MDIDocument}"`
* Style for the `ve:ResizeBoundsControl` type.

This example illustrates how to modify these resources. The necessary functionality is implemented in the `DisableFloatingPanelTransparencyBehavior` attached behavior class.
</details>
