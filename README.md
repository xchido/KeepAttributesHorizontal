# KeepAttributesHorizontal
AutoCAD 2018 plug-in for keeping block attributes parallel to the WCS x-axis.
Load your plug-in into AutoCAD

Type NETLOAD on the AutoCAD command-line followed by <Enter>. In the file dialog that appears, navigate to the location of the .NET DLL you just built using Visual Studio. If you saved teh app in C:\test, this will be C:\test\KeepAttributesHorizontal\KeepAttributesHorizontal\bin\Release. Select the KeepAttributesHorizontal.dll file and click Open.

Try it out

Type KEEPSTRAIGHT at the command-line and hit <Enter> - this runs the custom command you defined in your plug-in. The behavior of every attribute in every drawing open in AutoCAD is now being modified by your plug-in. To see this changed behavior, use the ROTATE command to rotate each of the block inserts in BlockWithAttributes.dwg. As you jig the block, you’ll see its attribute(s) remain parallel to the WCS x-axis. 

Note - This change to the attribute is permanent. Don’t save the drawing if you don’t want to keep the changes.
