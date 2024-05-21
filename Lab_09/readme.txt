EventWatcherDemo:
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project. The binary will be deployed to <Navisworks Installation Path>\Plugins
3. Launch Navisworks. A dialog will pop out with the message 'ActiveDocumentChanged'. After Navisworks is opened, switch the document, new a document, append model or merge model, a message will pop out 'ActiveDocument_Models_CollectionChanged'

Lab_Events
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project. The binary will be deployed to <Navisworks Installation Path>\Plugins
3. Launch Navisworks. In [Tool add-ins *] tab, a button 'Manipulate Events' is available. 
4. Click the button, saved viewpoint changed event starts. swtich the saved viewpoints, the corresponding view will be snapshot and export to an image to c:\temp
5. Click the button again, the event will stop