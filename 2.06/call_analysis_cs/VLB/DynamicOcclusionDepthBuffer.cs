using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
{
	public LayerMask layerMask;

	public bool useOcclusionCulling;

	public int depthMapResolution;

	public float fadeDistanceToSurface;

	private Camera m_DepthCamera;

	private bool m_NeedToUpdateOcclusionNextFrame;

	[CallerCount(Count = 0)]
	protected override string GetShaderKeyword()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
	{
		return default(MaterialManager.DynamicOcclusion);
	}

	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessOcclusionInternal()
	{
	}

	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_aspect")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateDepthCameraPropertiesAccordingToBeam()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	public bool HasLayerMaskIssues()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnValidateProperties()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnEnablePostValidate")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void InstantiateOrActivateDepthCamera()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	protected override void OnEnablePostValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 6)]
	private void DestroyDepthCamera()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[CallerCount(Count = 0)]
	public DynamicOcclusionDepthBuffer()
	{
	}
}
