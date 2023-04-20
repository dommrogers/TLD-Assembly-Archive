using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
{
	private sealed class _003CCoUpdateFadeOut_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeamGeometry _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCoUpdateFadeOut_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(Config), Member = "get_fadeOutCameraTransform")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "ComputeFadeOutFactor")]
		[Calls(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private VolumetricLightBeam m_Master;

	private Matrix4x4 m_ColorGradientMatrix;

	private MeshType m_CurrentMeshType;

	private Material m_CustomMaterial;

	private MaterialModifier.Callback m_MaterialModifierCallback;

	private Coroutine m_CoFadeOut;

	private MaterialManager.StaticProperties m_StaticProperties;

	private MeshRenderer _003CmeshRenderer_003Ek__BackingField;

	private MeshFilter _003CmeshFilter_003Ek__BackingField;

	private Mesh _003CconeMesh_003Ek__BackingField;

	private Camera m_CurrentCameraRenderingSRP;

	public MeshRenderer meshRenderer
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	public MeshFilter meshFilter
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 64)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	public Mesh coneMesh
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	public bool visible
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnEnable")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnDisable")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int sortingLayerID
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingLayerID")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingLayerName")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingOrder")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public bool _INTERNAL_IsFadeOutCoroutineRunning
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public static bool isCustomRenderPipelineSupported
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	private bool shouldUseGPUInstancedMaterial
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	private bool isNoiseEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	private bool isDepthBlendEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(_003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private float ComputeFadeOutFactor(Transform camTransform)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__31))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CoUpdateFadeOut()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void ComputeFadeOutFactor()
	{
	}

	[CalledBy(Type = typeof(_003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetFadeOutFactorProp(float value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "SetFadeOutValue")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnFadeOutStateChanged")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void RestartFadeOutCoroutine()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginCameraRendering")]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetOrAddComponent")]
	[Calls(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
	[Calls(Type = typeof(MaterialManager), Member = "NewMaterialTransient")]
	[Calls(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	[Calls(Type = typeof(Utils), Member = "GetPath")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_sortingOrder")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 16)]
	public void Initialize(VolumetricLightBeam master)
	{
	}

	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(GlobalMesh), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(MeshFilter), Member = "set_mesh")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public void RegenerateMesh()
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private Vector3 ComputeLocalMatrix()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetFloatPackingPrecision")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[Calls(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
	[Calls(Type = typeof(MaterialManager), Member = "GetInstancedMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ApplyMaterial()
	{
		return false;
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaterialProp(int nameID, float value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetMaterialProp(int nameID, Vector4 value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetMaterialProp(int nameID, Color value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetMaterialProp(int nameID, Matrix4x4 value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaterialProp(int nameID, Texture value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaterialChangeStart()
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaterialChangeStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Utils), Member = "GetFloatPackingPrecision")]
	[Calls(Type = typeof(Utils), Member = "SampleInMatrix")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_additionalClippingPlane")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[Calls(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void UpdateMaterialAndBounds()
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMatricesPropertiesForGPUInstancingSRP()
	{
	}

	[CallerCount(Count = 0)]
	private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnWillRenderObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "OnWillRenderObject")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnWillCameraRenderThisBeam")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateCameraRelatedProperties(Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BeamGeometry()
	{
	}
}
