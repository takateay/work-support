```
@Echo Off
For %%i In (%*) Do (
  Call :SUB %%i
)
Exit /b
:SUB
echo %1
Exit /b
```