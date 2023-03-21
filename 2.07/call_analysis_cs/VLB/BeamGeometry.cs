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
	private sealed class _003CCoUpdateFadeOut_003Ed__31 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BeamGeometry _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
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
		public _003CCoUpdateFadeOut_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(Config), Member = "get_fadeOutCameraTransform")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BeamGeometry), Member = "ComputeFadeOutFactor")]
		[Calls(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public MeshFilter meshFilter
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
			return default(bool);
		}
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnDisable")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
		set
		{
		}
	}

	public int sortingLayerID
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingLayerID")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingLayerName")]
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
			return default(int);
		}
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CalledBy(Type = typeof(VolumetricLightBeam), Member = "set_sortingOrder")]
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
			return default(bool);
		}
	}

	public static bool isCustomRenderPipelineSupported
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	private bool shouldUseGPUInstancedMaterial
	{
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	private bool isNoiseEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	private bool isDepthBlendEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(_003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float ComputeFadeOutFactor(Transform camTransform)
	{
		return default(float);
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
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(_003CCoUpdateFadeOut_003Ed__31), Member = "MoveNext")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	private void SetFadeOutFactorProp(float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "OnFadeOutStateChanged")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "SetFadeOutValue")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void RestartFadeOutCoroutine()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginCameraRendering")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(BeamGeometry), Member = "set_sortingLayerID")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[Calls(Type = typeof(BeamGeometry), Member = "RestartFadeOutCoroutine")]
	[Calls(Type = typeof(BeamGeometry), Member = "set_sortingOrder")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetPath")]
	[Calls(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	[Calls(Type = typeof(MaterialManager), Member = "NewMaterialTransient")]
	[Calls(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "Format")]
	public void Initialize(VolumetricLightBeam master)
	{
	}

	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(MeshFilter), Member = "set_mesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "GenerateGeometry")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GlobalMesh), Member = "Get")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	public void RegenerateMesh()
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private Vector3 ComputeLocalMatrix()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(MaterialManager), Member = "GetInstancedMaterial")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "Initialize")]
	[Calls(Type = typeof(MaterialManager.StaticProperties), Member = "ApplyToMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(Utils), Member = "GetFloatPackingPrecision")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	private bool ApplyMaterial()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaterialProp(int nameID, float value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	public void SetMaterialProp(int nameID, Vector4 value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public void SetMaterialProp(int nameID, Color value)
	{
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetMaterialProp(int nameID, Matrix4x4 value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaterialProp(int nameID, Texture value)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallsUnknownMethods(Count = 2)]
	private void MaterialChangeStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetFadeOutFactorProp")]
	private void MaterialChangeStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(Utils), Member = "SetKeywordEnabled")]
	public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[Calls(Type = typeof(Noise3D), Member = "get_isSupported")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Noise3D), Member = "LoadIfNeeded")]
	[Calls(Type = typeof(BeamGeometry), Member = "ComputeLocalMatrix")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_skewingLocalForwardDirectionNormalized")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(VolumetricLightBeam), Member = "UpdateAfterManualPropertyChange")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_additionalClippingPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_hasMeshSkewing")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Utils), Member = "SampleInMatrix")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Utils), Member = "GetFloatPackingPrecision")]
	public void UpdateMaterialAndBounds()
	{
	}

	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void UpdateMatricesPropertiesForGPUInstancingSRP()
	{
	}

	[CallerCount(Count = 0)]
	private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	private void OnWillRenderObject()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateCameraRelatedProperties")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[Calls(Type = typeof(Camera), Member = "get_depthTextureMode")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStop")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "GetInsideBeamFactorFromObjectSpacePos")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnWillCameraRenderThisBeam")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnWillRenderObject")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BeamGeometry), Member = "MaterialChangeStart")]
	[Calls(Type = typeof(BeamGeometry), Member = "SetMaterialProp")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	private void UpdateCameraRelatedProperties(Camera cam)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BeamGeometry()
	{
	}
}
