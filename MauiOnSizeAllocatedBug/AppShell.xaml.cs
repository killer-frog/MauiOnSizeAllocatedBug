using System.Diagnostics;

namespace MauiOnSizeAllocatedBug;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Debug.WriteLine("*** AppShell ctor");
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        Debug.WriteLine($"*** Size allocated (w:h): {width}x{height}");
        base.OnSizeAllocated(width, height);
    }

    protected override void ChangeVisualState()
    {
        base.ChangeVisualState();
        Debug.WriteLine($"*** Change VisualState (w x h) {Width}x{Height}");
    }
}