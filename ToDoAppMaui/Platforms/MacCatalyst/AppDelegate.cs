﻿
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ToDoAppMaui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}