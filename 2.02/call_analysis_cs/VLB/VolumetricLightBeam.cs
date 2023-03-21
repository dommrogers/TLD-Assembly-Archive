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
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CCoPlaytimeUpdate_003Ed__184(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallsUnknownMethods(Count = 3)]
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
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_meshStats")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float coneRadiusEnd
	{
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneVolume")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[Calls(Type = typeof(Utils), Member = "ComputeConeRadiusEnd")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		get
		{
			return default(float);
		}
	}

	public float coneVolume
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		get
		{
			return default(float);
		}
	}

	public float coneApexOffsetZ
	{
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		get
		{
			return default(float);
		}
	}

	public int geomSides
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		set
		{
		}
	}

	public int geomSegments
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		set
		{
		}
	}

	public Vector3 skewingLocalForwardDirectionNormalized
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector4 additionalClippingPlane
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CallsUnknownMethods(Count = 3)]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		get
		{
			return default(float);
		}
	}

	public bool isNoiseEnabled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public int sortingLayerID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
		[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingOrder")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool trackChangesDuringPlaytime
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public Bounds bounds
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		get
		{
			return default(Bounds);
		}
	}

	public int blendingModeAsInt
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(Quaternion), Member = "get_identity")]
		[Calls(Type = typeof(Vector3), Member = "get_up")]
		[Calls(Type = typeof(Vector3), Member = "get_right")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		get
		{
			return default(Quaternion);
		}
	}

	public Vector3 beamLocalForward
	{
		[Calls(Type = typeof(Vector3), Member = "get_right")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 lossyScale
	{
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		get
		{
			return default(Vector3);
		}
	}

	public float raycastDistance
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		get
		{
			return default(float);
		}
	}

	public Vector3 raycastGlobalForward
	{
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[CallsDeduplicatedMethods(Count = 4)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalUp
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[Calls(Type = typeof(Transform), Member = "get_up")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalRight
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(Transform), Member = "get_right")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get__INTERNAL_DynamicOcclusionMode_Runtime")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
		get
		{
			return default(MaterialManager.DynamicOcclusion);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get__INTERNAL_DynamicOcclusionMode")]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public string meshStats
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return default(int);
		}
	}

	public int meshTrianglesCount
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	private Light lightSpotAttached
	{
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	public event OnWillCameraRenderCB onWillCameraRenderThisBeam
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallerCount(Count = 0)]
	public void GetInsideAndOutsideIntensity(out float inside, out float outside)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref inside) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref outside) = null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "DisableOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlaneOff")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDestroy")]
	[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "RegisterOnBeamGeometryInitializedCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnEnable")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CallOnBeamGeometryInitializedCallback()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutEnd")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutBegin")]
	[CallsUnknownMethods(Count = 1)]
	private void SetFadeOutValue(ref float propToChange, float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnFadeOutStateChanged()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public float GetInsideBeamFactor(Vector3 posWS)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactor")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
	{
		return default(float);
	}

	[Obsolete]
	[DeduplicatedMethod]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Generate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[Calls(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[Calls(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lightSpotAttached")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "AssignPropertiesFromSpotLight")]
	public virtual void GenerateGeometry()
	{
	}

	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "AssignPropertiesFromSpotLight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lightSpotAttached")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual void UpdateAfterManualPropertyChange()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CoPlaytimeUpdate")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_trackChangesDuringPlaytime")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 2)]
	private void StartPlaytimeUpdateIfNeeded()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private IEnumerator CoPlaytimeUpdate()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DestroyBeam()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Light), Member = "get_range")]
	[Calls(Type = typeof(Light), Member = "get_spotAngle")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	[CallsUnknownMethods(Count = 3)]
	private void AssignPropertiesFromSpotLight(Light lightSpot)
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ClampProperties()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lightSpotAttached")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "AssignPropertiesFromSpotLight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	private void ValidateProperties()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public VolumetricLightBeam()
	{
	}
}
