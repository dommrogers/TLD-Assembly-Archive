using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	internal enum MipLevel
	{
		Original,
		L1,
		L2,
		L3,
		L4,
		L5,
		L6
	}

	private enum Pass
	{
		DepthCopy,
		CompositionDeferred,
		CompositionForward,
		DebugOverlay
	}

	private readonly float[] m_SampleThickness;

	private readonly float[] m_InvThicknessTable;

	private readonly float[] m_SampleWeightTable;

	private readonly int[] m_ScaledWidths;

	private readonly int[] m_ScaledHeights;

	private AmbientOcclusion m_Settings;

	private PropertySheet m_PropertySheet;

	private PostProcessResources m_Resources;

	private RenderTexture m_AmbientOnlyAO;

	private readonly RenderTargetIdentifier[] m_MRT;

	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public MultiScaleVO(AmbientOcclusion settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 19)]
	public void SetResources(PostProcessResources resources)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Release(CommandBuffer cmd, int id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private Vector4 CalculateZBufferParams(Camera camera)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	private float CalculateTanHalfFovHeight(Camera camera)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private Vector2 GetSize(MipLevel mip)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetSizeArray(MipLevel mip)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushReleaseCommands")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 94)]
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 33)]
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeFloatParams")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 121)]
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 17)]
	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 26)]
	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[CallsUnknownMethods(Count = 1)]
	private void PushDebug(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Release()
	{
	}
}
