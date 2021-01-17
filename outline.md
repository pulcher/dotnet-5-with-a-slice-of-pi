# Talk Outline

## Requirements

* VsCode
  * site version required
  *Remote Development
ms-vscode-remote.vscode-remote-extensionpack
  * <https://code.visualstudio.com/docs/remote/ssh>
  *
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
  ```
  curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -r linux-arm -v latest -l ~/vsdbg
  ```
  * cmdLine?  or graphical  

* Visual Studio Community
  * should run out of the box

## Get Started

* Setup SSH
  * Windows 10 now include ssh
  * passphrase login
    1. Setup the Linux instance to accept ssh (that is another section)
    1. Generate a key
        ssh-keygen -t rsa -b 4096
    1. Append .pub to .ssh/authorized_keys on linux
    1. try and ssh in. 

* Setup RPI
  * Add the follow to your .bashrc(or whatever start . file you have)
```
    export DOTNET_ROOT=$HOME/dotnet
    export PATH=$PATH:$HOME/dotnet
```

  * where to install dotnet
  <https://dotnet.microsoft.com/download/dotnet/5.0>
  <https://docs.microsoft.com/en-us/dotnet/core/install/linux>
  <https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu>
    * what OS's are supported
    ```

    ```
    * Install the pre-eeqs
    ```
    wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
    ```
    * Problem with ARM processors
    ```
     Important

Package manager installs are only supported on the x64 architecture. Other architectures, such as ARM, must install .NET by some other means such as with Snap, an installer script, or through a manual binary installation
    ```
    * Manual install on ARM processors:
      * URL: <https://docs.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#manual-install>
      ```
      mkdir -p "$HOME/dotnet" && tar zxf dotnet-sdk-5.0.100-linux-x64.tar.gz -C "$HOME/dotnet"
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
      ```
  * general system location stuff
* Remote Debugger
* Prove stuff installed correctly.

### ssh key gen information:
Choosing an Algorithm and Key Size
SSH supports several public key algorithms for authentication keys. These include:

rsa - an old algorithm based on the difficulty of factoring large numbers. A key size of at least 2048 bits is recommended for RSA; 4096 bits is better. RSA is getting old and significant advances are being made in factoring. Choosing a different algorithm may be advisable. It is quite possible the RSA algorithm will become practically breakable in the foreseeable future. All SSH clients support this algorithm.

dsa - an old US government Digital Signature Algorithm. It is based on the difficulty of computing discrete logarithms. A key size of 1024 would normally be used with it. DSA in its original form is no longer recommended.

ecdsa - a new Digital Signature Algorithm standarized by the US government, using elliptic curves. This is probably a good algorithm for current applications. Only three key sizes are supported: 256, 384, and 521 (sic!) bits. We would recommend always using it with 521 bits, since the keys are still small and probably more secure than the smaller keys (even though they should be safe as well). Most SSH clients now support this algorithm.

ed25519 - this is a new algorithm added in OpenSSH. Support for it in clients is not yet universal. Thus its use in general purpose applications may not yet be advisable.

The algorithm is selected using the -t option and key size using the -b option. The following commands illustrate:

```
ssh-keygen -t rsa -b 4096
ssh-keygen -t dsa
ssh-keygen -t ecdsa -b 521
ssh-keygen -t ed25519
```

## Setup VSCode

* Terminal features
* setup passwordless login
  * not required but really really really nice.

## Setup Visual Studio

Save this to last, show cross-compile?

## Hello World

* dotnet new console -o helloworld
  * show that running on the rpi
  * stuff
  ```
  ubuntu@ubuntu:~/work$ dotnet new console -o hello-world
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on hello-world/hello-world.csproj...
  Determining projects to restore...
  Restored /home/ubuntu/work/hello-world/hello-world.csproj (in 320 ms).
Restore succeeded.

ubuntu@ubuntu:~/work$ dir
hello-world  hw
ubuntu@ubuntu:~/work$ cd hello-world/
ubuntu@ubuntu:~/work/hello-world$ dir
Program.cs  hello-world.csproj  obj
ubuntu@ubuntu:~/work/hello-world$ ls -l
total 12
-rw-rw-r-- 1 ubuntu ubuntu  193 Jan 17 03:36 Program.cs
-rw-rw-r-- 1 ubuntu ubuntu  219 Jan 17 03:36 hello-world.csproj
drwxrwxr-x 2 ubuntu ubuntu 4096 Jan 17 03:36 obj
  ```
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
* how to check what version is installed: <https://docs.microsoft.com/en-us/dotnet/core/install/how-to-detect-installed-versions?pivots=os-linux>
* dotnet supported versions: <https://github.com/dotnet/core/blob/master/release-notes/5.0/5.0-supported-os.md>
* get the timeline from here: <https://devblogs.microsoft.com/dotnet/introducing-net-5/>
* more infor on .net 5 and graphics: <https://auth0.com/blog/dotnet-5-whats-new/>
* install on linux: <https://docs.microsoft.com/en-us/dotnet/core/install/linux>


## cool stuff to go research

* 2FA on linux: <https://www.digitalocean.com/community/tutorials/how-to-set-up-multi-factor-authentication-for-ssh-on-ubuntu-20-04>


