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

public class RowDefinition : DefinitionBase {
  internal new static RowDefinition CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RowDefinition(cPtr, cMemoryOwn);
  }

  internal RowDefinition(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RowDefinition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public RowDefinition() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_RowDefinition();
  }

  public new static DependencyProperty HeightProperty {
    set {
      NoesisGUI_PINVOKE.RowDefinition_HeightProperty_set(DependencyProperty.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RowDefinition_HeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public new static DependencyProperty MinHeightProperty {
    set {
      NoesisGUI_PINVOKE.RowDefinition_MinHeightProperty_set(DependencyProperty.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RowDefinition_MinHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public new static DependencyProperty MaxHeightProperty {
    set {
      NoesisGUI_PINVOKE.RowDefinition_MaxHeightProperty_set(DependencyProperty.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RowDefinition_MaxHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public new GridLength Height {
    set {
      NoesisGUI_PINVOKE.RowDefinition_Height_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.RowDefinition_Height_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<GridLength>(ret);
      }
      else {
        return new GridLength();
      }
    }

  }

  public new float MaxHeight {
    set {
      NoesisGUI_PINVOKE.RowDefinition_MaxHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.RowDefinition_MaxHeight_get(swigCPtr);
      return ret;
    } 
  }

  public new float MinHeight {
    set {
      NoesisGUI_PINVOKE.RowDefinition_MinHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.RowDefinition_MinHeight_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RowDefinition_GetStaticType();
    return ret;
  }

}

}

