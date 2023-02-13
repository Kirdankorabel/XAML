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

public class GeometryGroup : Geometry {
  internal new static GeometryGroup CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GeometryGroup(cPtr, cMemoryOwn);
  }

  internal GeometryGroup(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GeometryGroup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GeometryGroup() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_GeometryGroup();
  }

  public override bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.GeometryGroup_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty ChildrenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GeometryGroup_ChildrenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FillRuleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GeometryGroup_FillRuleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public GeometryCollection Children {
    set {
      NoesisGUI_PINVOKE.GeometryGroup_Children_set(swigCPtr, GeometryCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GeometryGroup_Children_get(swigCPtr);
      return (GeometryCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FillRule FillRule {
    set {
      NoesisGUI_PINVOKE.GeometryGroup_FillRule_set(swigCPtr, (int)value);
    } 
    get {
      FillRule ret = (FillRule)NoesisGUI_PINVOKE.GeometryGroup_FillRule_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.GeometryGroup_GetStaticType();
    return ret;
  }

}

}

