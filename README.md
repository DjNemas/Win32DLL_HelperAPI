# Win32DLLTest

A helper API that provides easyer using of Win32.DLL functions.

## In Development

### Currently Available: 
```cs
Win32Mouse mouse = new();
mouse.ExternalMouseFunctionStatusCode += Mouse_ExternalMouseFunctionStatusCode;
mouse.SetMousePos();
mouse.ClickMouseButton();
mouse.Wait();
mouse.GetMouseHandler();
mouse.GetMouseInfo();
mouse.GetMouseMonitorPos();
mouse.MoveMouseMonitor();
```
