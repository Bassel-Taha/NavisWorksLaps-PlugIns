Nw_Single_Doc_With_View
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project.  It is a standalone EXE  
3. Run the project. In file >> open, select a file, it will be displayed in the viewer.
4. button [Orbit], [Select] can swtich the navigation mode
5. select any objects in advanced, click button [Find Insersect Box], it will highlight the items whose boundingbox intersect with these selected items. And make other items transparency. 


Nw_Without_View_control
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project.  It is a standalone EXE  
3. Run the project.it will ask you to select a file. Please select the demo file gatehouse.nwd in <Test Files> folder.
4. It will find the specific model item whose entity handle value is "16C17", change its color and save this file to a new nwd file in 2014 format.


Nw_Multi_Doc_without_COM
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project.  It is a standalone EXE  
3. Run the project.
4. Click button [Open Document 1], it will ask you to select a file. then view control in the left side will display this model
5. Click button [Open Document 2], it will ask you to select a file. then view control in the right side will display this model
6. select any model in view control 1 or 2, click button [change color of current selection], the color of the objects in the activated view will be changed.

Nw_Single_Doc_With_COM
1. Open the project in Visual Studio. Make sure the relevant references of Navisworks are correctly loaded, otherwise, find them at <Navisworks Installation Path>.
2. Build the project.  It is a standalone EXE  
3. Run the project.
4. it will ask you to select a file. Please select the demo file gatehouse.nwd in <Test Files> folder.
5. It will find the specific model item whose entity handle value is "16C17", add some custom property to this item, and save this file to a new nwd file in 2014 format.