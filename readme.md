### Screen capture library

This repository contains a class project to capture the current desktop or a specific window or control.

Example to capture a Windows form button.

```csharp
private void CaptureThisButton_Click(object sender, EventArgs e)
{
    var ops = new ScreenCapture();
    pictureBox1.Image = ops.CaptureWindow(CaptureThisButton.Handle);
}
```
Example to capture the current desktop

```csharp
private void CaptureDesktopButton_Click(object sender, EventArgs e)
{
    var ops = new ScreenCapture();
    pictureBox2.Image = ops.CaptureScreen();
}
```
