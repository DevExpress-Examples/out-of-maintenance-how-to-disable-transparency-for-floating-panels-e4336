<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643460/12.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4336)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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
