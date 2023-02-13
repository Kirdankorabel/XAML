//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class MouseButtonEventArgs : MouseEventArgs {
  private HandleRef swigCPtr;

  internal MouseButtonEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MouseButtonEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MouseButtonEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_MouseButtonEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    MouseButtonEventHandler handler_ = (MouseButtonEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new MouseButtonEventArgs(args, false));
    }
  }

  public int ClickCount {
    get {
      return GetClickCountHelper();
    }
  }

  public MouseButton ChangedButton {
    get {
      MouseButton ret = (MouseButton)NoesisGUI_PINVOKE.MouseButtonEventArgs_ChangedButton_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonState ButtonState {
    get {
      MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.MouseButtonEventArgs_ButtonState_get(swigCPtr);
      return ret;
    } 
  }

  public MouseButtonEventArgs(object s, RoutedEvent e, MouseButton button, MouseButtonState state, uint clicks) : this(NoesisGUI_PINVOKE.new_MouseButtonEventArgs(Noesis.Extend.GetInstanceHandle(s), RoutedEvent.getCPtr(e), (int)button, (int)state, clicks), true) {
  }

  private int GetClickCountHelper() {
    int ret = NoesisGUI_PINVOKE.MouseButtonEventArgs_GetClickCountHelper(swigCPtr);
    return ret;
  }

}

}

