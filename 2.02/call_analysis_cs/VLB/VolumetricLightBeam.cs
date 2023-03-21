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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCoPlaytimeUpdate_003Ed__184(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
			return 0f;
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
			return 0f;
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float coneAngle
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "SetParticleProperties")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_meshStats")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float coneRadiusEnd
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneVolume")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[Calls(Type = typeof(Utils), Member = "ComputeConeRadiusEnd")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float coneVolume
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		get
		{
			return 0f;
		}
	}

	public float coneApexOffsetZ
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		get
		{
			return 0f;
		}
	}

	public int geomSides
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int geomSegments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Vector3 skewingLocalForwardDirectionNormalized
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector4 additionalClippingPlane
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[CallsDeduplicatedMethods(Count = 3)]
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
			return false;
		}
	}

	public bool hasMeshSkewing
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool fadeEndFromLight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
			return 0f;
		}
	}

	public float fadeStart
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
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
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float maxGeometryDistance
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public bool isNoiseEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool noiseEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
			return 0f;
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
			return 0f;
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
			return false;
		}
	}

	public bool isTilted
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
	}

	public int sortingLayerID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
		[CallsDeduplicatedMethods(Count = 2)]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "set_sortingOrder")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return false;
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
			return false;
		}
	}

	public bool hasGeometry
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Bounds bounds
	{
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "UpdateCulling")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public Quaternion beamInternalLocalRotation
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(VolumetricDustParticles), Member = "InstantiateParticleSystem")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Quaternion), Member = "get_identity")]
		[Calls(Type = typeof(Vector3), Member = "get_right")]
		[Calls(Type = typeof(Vector3), Member = "get_up")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(Quaternion);
		}
	}

	public Vector3 beamLocalForward
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Vector3), Member = "get_right")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 lossyScale
	{
		[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return default(Vector3);
		}
	}

	public float raycastDistance
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[Calls(Type = typeof(Mathf), Member = "Approximately")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public Vector3 raycastGlobalForward
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Transform), Member = "get_forward")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalUp
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(Transform), Member = "get_up")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 raycastGlobalRight
	{
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
		[Calls(Type = typeof(Transform), Member = "get_right")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "get__INTERNAL_DynamicOcclusionMode_Runtime")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Config), Member = "get_Instance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
			return 0;
		}
	}

	public uint _INTERNAL_InstancedMaterialGroupID
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	public int meshVerticesCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return 0;
		}
	}

	public int meshTrianglesCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return 0;
		}
	}

	private Light lightSpotAttached
	{
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void GetInsideAndOutsideIntensity(out float inside, out float outside)
	{
		inside = default(float);
		outside = default(float);
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDestroy")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "DisableOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlaneOff")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnEnable")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "RegisterOnBeamGeometryInitializedCallback")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CallOnBeamGeometryInitializedCallback()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutBegin")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_fadeOutEnd")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetFadeOutValue(ref float propToChange, float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnFadeOutStateChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public float GetInsideBeamFactor(Vector3 posWS)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
	{
		return 0f;
	}

	[Obsolete]
	[DeduplicatedMethod]
	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Generate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lightSpotAttached")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "AssignPropertiesFromSpotLight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "NewWithComponent")]
	[Calls(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[Calls(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void GenerateGeometry()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lightSpotAttached")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "AssignPropertiesFromSpotLight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "ClampProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_visible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_trackChangesDuringPlaytime")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CoPlaytimeUpdate")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartPlaytimeUpdateIfNeeded()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "StartPlaytimeUpdateIfNeeded")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CoPlaytimeUpdate()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DestroyBeam()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "ValidateProperties")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Light), Member = "get_range")]
	[Calls(Type = typeof(Light), Member = "get_spotAngle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void AssignPropertiesFromSpotLight(Light lightSpot)
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
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
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public VolumetricLightBeam()
	{
	}
}
