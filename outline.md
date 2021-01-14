# Talk Outline

## Requirements

* VsCode
  * site version required
* .NET 5
  * Location of the bundle to download
    * what those bundles mean
  * commands to install/retrieve
    * wget, etc...
  * Where to install dotnet for access from everyone
  * project file  
* Linux machine
  * could be virtual
  * Current use
    * Ubuntu 20.04 LTS
    * Raspberry Pi 4 4GB
      * on a donkey 
* Laptop/Desktop
  * Windows 10 pro
  * WSL2
    * gets me
      * wget
      * ssh
      * scp
      * etc...
  * Windows Terminal Server
* Remote Debugger
  * install
  * cmdLine?  or graphical  

* Visual Studio Community
  * should run out of the box

## Get Started

* Setup SSH
  * passphrase login
  * file copy?

* Setup RPI
  * .ssh folder
  * PATH
  * where to install dotnet
  * general system location stuff
* Remote Debugger
* Prove stuff installed correctly.

## Setup VSCode

* Terminal features
* setup passwordless login
  * not required but really really really nice.

## Setup Visual Studio

Save this to last, show cross-compile?

## Hello World

* dotnet new console helloworld
  * show that running on the rpi
* dotnet new console helooIot
  * install GPIO package
  * push a button
  * blink LED
  * show pinout graphic
* Useful dotnet commands
  * dotnet restore
  * dotnet list packages
  * dotnet build
  * dotnet publish
  * dotnet other stuff  

## Getting around a Linux/Unix system
* base level command
* PATH
* where most stuff lives

## Demos

* Talking Head walk through
  * uses systemd like any other Linux system
  * forks a process to make the talky-talk
  * logs stuff
  * understands startup and shutdown
  * get started with a dotnet new worker blah

## Resources

* Talk repo: <https://github.com/pulcher/dotnet-5-with-a-slice-of-pi>
* Talking head repo: <https://github.com/pulcher/TalkingHead>
* some uk guy: <https://www.petecodes.co.uk/install-and-use-microsoft-dot-net-5-with-the-raspberry-pi/>
* setup debugging on rpi with vscode: <https://docs.microsoft.com/en-us/dotnet/iot/debugging?pivots=vscode>
* deploy .NET apps on rpi: <https://docs.microsoft.com/en-us/dotnet/iot/deployment>
* debug .NET core on RPI attach to remote process: <https://docs.microsoft.com/en-us/visualstudio/debugger/remote-debugging-dotnet-core-linux-with-ssh?view=vs-2019>
* enable ssh on a rpi: <https://www.raspberrypi.org/documentation/remote-access/ssh/>
* hansleman's stuff: <https://www.hanselman.com/blog/remote-debugging-with-vs-code-on-windows-to-a-raspberry-pi-using-net-core-on-arm>
* omnisharp ssh setup: <https://github.com/OmniSharp/omnisharp-vscode/wiki/Attaching-to-remote-processes>
* omnisharp remote debuggin: <https://github.com/OmniSharp/omnisharp-vscode/wiki/Remote-Debugging-On-Linux-Arm>
* deploying optons: <https://docs.microsoft.com/en-us/dotnet/core/deploying/>
* dotnet publish docs: <https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish>
* dotnet ready-to-run: <https://docs.microsoft.com/en-us/dotnet/core/deploying/ready-to-run>
* where to go and get .NET 5: <https://dotnet.microsoft.com/download/dotnet/5.0>
*
