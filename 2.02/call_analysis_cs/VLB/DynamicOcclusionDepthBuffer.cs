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
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_aspect")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneAngle")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_maxGeometryDistance")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "ProcessOcclusionInternal")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "InstantiateOrActivateDepthCamera")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_beamInternalLocalRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneApexOffsetZ")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	private void UpdateDepthCameraPropertiesAccordingToBeam()
	{
	}

	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasLayerMaskIssues()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnValidateProperties")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnValidateProperties()
	{
	}

	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnEnablePostValidate")]
	[Calls(Type = typeof(DynamicOcclusionDepthBuffer), Member = "UpdateDepthCameraPropertiesAccordingToBeam")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Camera), Member = "set_targetTexture")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 11)]
	private void DestroyDepthCamera()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public DynamicOcclusionDepthBuffer()
	{
	}
}
