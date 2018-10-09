pyinstaller -n "Listener" -F -i "icon.ico" Listener.py

echo f | xcopy /f /y /s dist\Listener.exe ..\Fishrodah\bin\Debug\Listener.exe
