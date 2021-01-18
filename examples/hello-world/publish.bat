dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true
cd ..
scp -v -r .\hello-world ubuntu@192.168.1.93:~/examples/hello-world
