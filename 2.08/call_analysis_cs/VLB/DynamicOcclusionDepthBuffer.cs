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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_aspect")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnValidateProperties()
	{
	}

	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnEnablePostValidate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected override void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	private void DestroyDepthCamera()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[CallerCount(Count = 0)]
	public DynamicOcclusionDepthBuffer()
	{
	}
}
