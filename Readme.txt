The package provides a UI button and Android Toast message method.
Install: 
1. Open Unity - Window - Package Manager
2. Click on + button at upper left to add package - Select Add package from git URL
 
3. In the url field paste this git url: https://github.com/venellinus1/androidtoast.git

How to use:
UI
1. Setting up UI - find the AndroidToast prefab in:
 Packages - Android Toast - Runtime - Prefabs 
2. Drag the prefab in Hierarchy
3. Setup the click event for the Button  in AndroidToast - Canvas - Views - Button
Note: the prefab comes with EventSystem object, if you already have one - please remove the EventSystem object from AndroidToast object

Android Toast
1. Add the namespace: 
using venelin.androidutils;
2. Sample implementation:
//import the namespace
using venelin.androidutils;

void ToastExample(string message) {
   Toast.ShowToast(message);
}


Note: When the package is installed, if TextMeshPro was not been initialized yet it may show this window  - please click on Import TMP Essentials 
