using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

public static class BlurMaker
{
    [DllImport("user32.dll")]
    static internal extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

    public static void EnableBlur(this UserControl @this)
    {
        @this.BackColor = Color.Azure;
        var accent = new AccentPolicy();
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
        var accentStructSize = Marshal.SizeOf(accent);
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
        var Data = new WindowCompositionAttributeData();
        Data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
        Data.SizeOfData = accentStructSize;
        Data.Data = accentPtr;
        SetWindowCompositionAttribute(@this.Handle, ref Data);
        Marshal.FreeHGlobal(accentPtr);
    }
    public static void EnableBlur(this Form @this)
    {
        @this.BackColor = Color.Azure;
        @this.TransparencyKey = Color.Azure;
        var accent = new AccentPolicy();
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
        var accentStructSize = Marshal.SizeOf(accent);
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
        var Data = new WindowCompositionAttributeData();
        Data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
        Data.SizeOfData = accentStructSize;
        Data.Data = accentPtr;
        SetWindowCompositionAttribute(@this.Handle, ref Data);
        Marshal.FreeHGlobal(accentPtr);
    }

}
enum AccentState
{
    ACCENT_ENABLE_BLURBEHIND = 3
}

struct AccentPolicy
{
    public AccentState AccentState;
    public int AccentFlags;
    public int GradientColor;
    public int AnimationId;
}

struct WindowCompositionAttributeData
{
    public WindowCompositionAttribute Attribute;
    public IntPtr Data;
    public int SizeOfData;
}

enum WindowCompositionAttribute
{
    WCA_ACCENT_POLICY = 19
}
