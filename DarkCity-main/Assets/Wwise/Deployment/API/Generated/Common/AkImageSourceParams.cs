#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkImageSourceParams : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkImageSourceParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkImageSourceParams obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkImageSourceParams() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkImageSourceParams(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkImageSourceParams() : this(AkSoundEnginePINVOKE.CSharp_new_AkImageSourceParams__SWIG_0(), true) {
  }

  public AkImageSourceParams(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel) : this(AkSoundEnginePINVOKE.CSharp_new_AkImageSourceParams__SWIG_1(AkVector.getCPtr(in_sourcePosition), in_fDistanceScalingFactor, in_fLevel), true) {
  }

  public AkVector sourcePosition { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_sourcePosition_set(swigCPtr, AkVector.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_sourcePosition_get(swigCPtr);
      AkVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public float fDistanceScalingFactor { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDistanceScalingFactor_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDistanceScalingFactor_get(swigCPtr); } 
  }

  public float fLevel { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fLevel_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fLevel_get(swigCPtr); } 
  }

  public float fDiffraction { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDiffraction_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_fDiffraction_get(swigCPtr); } 
  }

  public byte uDiffractionEmitterSide { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(swigCPtr); } 
  }

  public byte uDiffractionListenerSide { set { AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionListenerSide_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkImageSourceParams_uDiffractionListenerSide_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.