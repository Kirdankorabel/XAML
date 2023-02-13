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

public class InertiaExpansionBehavior : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InertiaExpansionBehavior(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(InertiaExpansionBehavior obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~InertiaExpansionBehavior() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_InertiaExpansionBehavior(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float DesiredDeceleration {
    set {
      NoesisGUI_PINVOKE.InertiaExpansionBehavior_DesiredDeceleration_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.InertiaExpansionBehavior_DesiredDeceleration_get(swigCPtr);
      return ret;
    } 
  }

  public InertiaExpansionBehavior() : this(NoesisGUI_PINVOKE.new_InertiaExpansionBehavior(), true) {
  }

}

}

