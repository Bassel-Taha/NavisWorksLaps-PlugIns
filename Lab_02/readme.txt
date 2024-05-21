1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project. The binary will be deployed to <Navisworks Installation Path>\Plugins
3. Launch Navisworks. 
   3.1 ) In [Tool add-ins *] tab, a button 'HelloWorld AddInTab' is available. Click the button, a message box pops out
   3.2 ) In context menu of current selection, a menu 'HelloWorld ContextMenu' is available. Click the button, a message box pops out
   3.3 ) In [View] tab >> [Workspace] panel >> [Windows] drop-down, a dock pane named 'HelloWorld DockPane Plugin' is available. tick it, the panel appears. It has a button that can pop out a message box. One demo code is available that shows how to load other plugin dynamically.
   