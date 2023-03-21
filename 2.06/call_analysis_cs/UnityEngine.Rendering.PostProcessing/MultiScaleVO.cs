using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[CallsUnknownMethods(Count = 14)]
	public MultiScaleVO(AmbientOcclusion settings)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public void SetResources(PostProcessResources resources)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat")]
	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[CallerCount(Count = 0)]
	private float CalculateTanHalfFovHeight(Camera camera)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Vector2 GetSize(MipLevel mip)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetSizeArray(MipLevel mip)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushReleaseCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Release")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 17)]
	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 15)]
	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	private void PushDebug(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsUnknownMethods(Count = 3)]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public void Release()
	{
	}
}
