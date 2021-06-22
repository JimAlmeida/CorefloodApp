# Coreflood App

### Introduction

This project is meant to demonstrate the capabilities of the Blazor Web View control for Windows Forms coming with the new launch of .NET 6. It seeks to provide a friendly interface based on Web technologies such as CSS and HTML with the support of Blazor for functionality.

### Requirements

.NET SDK v. 6.0.100-preview.4.21255.9

### What does it do?

The Coreflood project begun as a college assignment during my studies of Reservoir Simulation, it seeks to solve the following problem:

_"To find the pressure and saturation fields during drainage and imbibition of a water-wet core sample (rock) using the two-phase IMPES numerical simulation."_

In its first iteration, the code was developed in C++ console application with no support for multithreading. Thereafter, during my studies of C++ multithreading, I added support for multithreading and added other optimizations such as solving the linear systems with the Thomas Algorithm rather than with a dense matrix solver.

Recently I ported the code to C#, and now with the launch of the .NET 6 and the Blazor WebView control for WinForms, it seems as good of an opportunity as any to give this project a proper GUI with the most recent frameworks such as Bootstrap and Blazor.

### How to install?

Use the installer located within the repository. It is a straightforward installer just take notice when selecting the installation directory because currently installing within the Program Files folder causes issues. Install it in a public folder.

Currently there are two issues when running the application:

1. When closing the application and disposing of the resources, an exception is raised which does not break the application at all but it is indicative of an issue. It does not ruin the user experience. This bug has been submitted to the Microsoft team for analysis.
2. If you install it in the Program Files folder, after launching the application, an exception will be thrown with the "Access is Denied" message. This is due to the WebView2 control writing local files in the installation folder during execution. Since any operation of the sort is forbidden for any folder within Program Files, you can't run the program unless it is installed in a public folder. 

Other than that, the experience is smooth. You can use the installer and enjoy the program or look at the pictures in the section below.

### Screen Captures

![CorefloodApp1](https://imgur.com/PSzSqp4.png)

![CorefloodApp2](https://imgur.com/TLthYHl.png)

![CorefloodApp3](https://imgur.com/x1X9Vko.png)
