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

	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 13)]
	public void SetResources(PostProcessResources resources)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
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
	[CalledBy(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
	{
	}

	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushReleaseCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushUpsampleCommands")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDownsampleCommands")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushAllocCommands")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushRenderCommands")]
	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "AllocArray")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MultiScaleVO), Member = "Alloc")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeFloatParams")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeFloatParams")]
	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 3)]
	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 2)]
	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAfterOpaque")]
	[CalledBy(Type = typeof(MultiScaleVO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 1)]
	private void PushDebug(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MultiScaleVO), Member = "GenerateAOMap")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PushDebug")]
	[Calls(Type = typeof(MultiScaleVO), Member = "PreparePropertySheet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiScaleVO), Member = "CheckAOTexture")]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 4)]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public void Release()
	{
	}
}
