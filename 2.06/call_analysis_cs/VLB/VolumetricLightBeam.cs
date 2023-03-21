using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class VolumetricLightBeam : MonoBehaviour
{
	public delegate void OnWillCameraRenderCB(Camera cam);

	public delegate void OnBeamGeometryInitialized();

	private sealed class _003CCoPlaytimeUpdate_003Ed__184 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VolumetricLightBeam _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CCoPlaytimeUpdate_003Ed__184(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public bool colorFromLight;

	public ColorMode colorMode;

	public Color color;

	public Gradient colorGradient;

	public bool intensityFromLight;

	public bool intensityModeAdvanced;

	public float intensityInside;

	public float intensityOutside;

	public BlendingMode blendingMode;

	public bool spotAngleFromLight;

	public float spotAngle;

	public float coneRadiusStart;

	public ShaderAccuracy shaderAccuracy;

	public MeshType geomMeshType;

	public int geomCustomSides;

	public int geomCustomSegments;

	public Vector3 skewingLocalForwardDirection;

	public Transform clippingPlaneTransform;

	public bool geomCap;

	public bool fallOffEndFromLight;

	public AttenuationEquation attenuationEquation;

	public float attenuationCustomBlending;

	public float fallOffStart;

	public float fallOffEnd;

	public float depthBlendDistance;

	public float cameraClippingDistance;

	public float glareFrontal;

	public float glareBehind;

	public float fresnelPow;

	public NoiseMode noiseMode;

	public float noiseIntensity;

	public bool noiseScaleUseGlobal;

	public float noiseScaleLocal;

	public bool noiseVelocityUseGlobal;

	public Vector3 noiseVelocityLocal;

	public Dimensions dimensions;

	public Vector2 tiltFactor;

	private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

	private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

	private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

	private int pluginVersion;

	private bool _TrackChangesDuringPlaytime;

	private int _SortingLayerID;

	private int _SortingOrder;

	private float _FadeOutBegin;

	private float _FadeOutEnd;

	private uint _003C_INTERNAL_InstancedMaterialGroupID_003Ek__BackingField;

	private BeamGeometry m_BeamGeom;

	private Coroutine m_CoPlaytimeUpdate;

	private Light _CachedLight;

	public ColorMode usedColorMode
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ColorMode);
		}
	}

	public float alphaInside
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float alphaOutside
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float intensityGlobal
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float coneAngle
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	public float coneRadiusEnd
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float coneVolume
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float coneApexOffsetZ
	{
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		get
		{
			return default(float);
		}
	}

	public int geomSides
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		set
		{
		}
	}

	public int geomSegments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		set
		{
		}
	}

	public Vector3 skewingLocalForwardDirectionNormalized
	{
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector4 additionalClippingPlane
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector4);
		}
	}

	public bool canHaveMeshSkewing
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool hasMeshSkewing
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		get
		{
			return default(bool);
		}
	}

	public bool fadeEndFromLight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float attenuationLerpLinearQuad
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float fadeStart
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float fadeEnd
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float maxGeometryDistance
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public bool isNoiseEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool noiseEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float fadeOutBegin
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "SetFadeOutValue")]
		set
		{
		}
	}

	public float fadeOutEnd
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "SetFadeOutValue")]
		set
		{
		}
	}

	public bool isFadeOutEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool isTilted
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int sortingLayerID
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		set
		{
		}
	}

	public string sortingLayerName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingOrder")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool trackChangesDuringPlaytime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isCurrentlyTrackingChanges
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool hasGeometry
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public Bounds bounds
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Bounds);
		}
	}

	public int blendingModeAsInt
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Enum), Member = "GetValues")]
		[Calls(Type = typeof(Array), Member = "get_Length")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public Quaternion beamInternalLocalRotation
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		get
		{
			return default(Quaternion);
		}
	}

	public Vector3 beamLocalForward
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 lossyScale
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return default(Vector3);
		}
	}

	public float raycastDistance
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[CallerCount(Count = 2)]
		get
		{
			return default(float);
		}
	}

	public Vector3 raycastGlobalForward
	{
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalUp
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Transform), Member = "get_up")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalRight
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Transform), Member = "get_right")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		get
		{
			return default(Vector3);
		}
	}

	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(MaterialManager.DynamicOcclusion);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(MaterialManager.DynamicOcclusion);
		}
	}

	public int _INTERNAL_pluginVersion
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public uint _INTERNAL_InstancedMaterialGroupID
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public string meshStats
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	public int meshVerticesCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public int meshTrianglesCount
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return default(int);
		}
	}

	private Light lightSpotAttached
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public event OnWillCameraRenderCB onWillCameraRenderThisBeam
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void GetInsideAndOutsideIntensity(out float inside, out float outside)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref inside) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outside) = null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlaneOff")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "DisableOcclusion")]
	[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnEnable")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "RegisterOnBeamGeometryInitializedCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void CallOnBeamGeometryInitializedCallback()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutBegin")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutEnd")]
	[CallsUnknownMethods(Count = 1)]
	private void SetFadeOutValue(ref float propToChange, float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnFadeOutStateChanged()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
	public float GetInsideBeamFactor(Vector3 posWS)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactor")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
	{
		return default(float);
	}

	[Obsolete("Use 'GenerateGeometry()' instead")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Generate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[Calls(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public virtual void GenerateGeometry()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallsUnknownMethods(Count = 1)]
	public virtual void UpdateAfterManualPropertyChange()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnEnable")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_trackChangesDuringPlaytime")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void StartPlaytimeUpdateIfNeeded()
	{
	}

	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__184))]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator CoPlaytimeUpdate()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void DestroyBeam()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Light), Member = "get_spotAngle")]
	[Calls(Type = typeof(Light), Member = "get_range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	private void AssignPropertiesFromSpotLight(Light lightSpot)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	private void ClampProperties()
	{
	}

	[Calls(Type = typeof(Light), Member = "get_spotAngle")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	[Calls(Type = typeof(Light), Member = "get_range")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void ValidateProperties()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallerCount(Count = 0)]
	public VolumetricLightBeam()
	{
	}
}
