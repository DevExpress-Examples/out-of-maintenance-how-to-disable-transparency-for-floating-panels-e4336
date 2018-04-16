# How to disable transparency for floating panels


<p>Floating panels are designed to have transparent elements.  To disable transparency, do the following:</p><p><br />
1) Deactivate the DockLayoutManager's AllowFloatGroupTransparency option.</p><p>2) Modify the built-in styles and templates that define floating panels' appearance and remove transparent elements. The following styles and templates should be modified:<br />
</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=EmptyBorderTemplate}"</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=FormBorderTemplate}"</p><p>- "{dxt:FloatPaneElementsThemeKey ResourceKey=SingleBorderTemplate}"</p><p>- "{dxt:DocumentPaneElementsThemeKey ResourceKey=MDIDocument}"</p><p>- Style for the "ve:ResizeBoundsControl" type.<br />
</p><p>This example illustrates how to modify these resources. The necessary functionality is implemented in the DisableFloatingPanelTransparencyBehavior attached behavior class.</p>

<br/>


