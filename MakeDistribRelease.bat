SET z=C:\Apps\Core\7-Zip\7z.exe
SET v=1.4
SET folder=TitleDisplay

mkdir %folder%
xcopy ..\TitleDisplay\*.cs %folder% /Y
xcopy ..\TitleDisplay\TitleDisplay.csproj %folder%\ /Y
xcopy ..\TitleDisplay\Properties %folder%\Properties /I /E /Y
xcopy ..\TitleDisplay\Forms %folder%\Forms /I /E /Y
xcopy ..\TitleDisplay\Resources %folder%\Resources /I /E /Y

KeePass.exe --plgx-create C:\Users\gogog\Downloads\kp\Build\%folder%

del  TitleDisplay-%v%.zip
%z% a TitleDisplay-%v%.zip TitleDisplay.plgx
%z% a TitleDisplay-%v%.zip License.txt
%z% a TitleDisplay-%v%.zip Readme.txt

rd /s /q ..\TitleDisplay\obj
rd /s /q ..\TitleDisplay\.vs
del  TitleDisplay-%v%-Source.zip
%z% a TitleDisplay-%v%-Source.zip ..\TitleDisplay
%z% d TitleDisplay-%v%-Source.zip .svn -r

del  TitleDisplay.dll
rd /s /q %folder%

