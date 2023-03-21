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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
	{
		return default(MaterialManager.DynamicOcclusion);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	private void ProcessOcclusionInternal()
	{
	}

	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_aspect")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	private void UpdateDepthCameraPropertiesAccordingToBeam()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnEnablePostValidate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	private void InstantiateOrActivateDepthCamera()
	{
	}

	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
