dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true
cd ..
ssh ubuntu@192.168.1.93 "mkdir -p ~/examples/pushBlink" && scp -v -r .\pushBlink ubuntu@192.168.1.93:~/examples/
