using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	private enum Pass
	{
		OcclusionEstimationForward,
		OcclusionEstimationDeferred,
		HorizontalBlurForward,
		HorizontalBlurDeferred,
		VerticalBlur,
		CompositionForward,
		CompositionDeferred,
		DebugOverlay
	}

	private RenderTexture m_Result;

	private PropertySheet m_PropertySheet;

	private AmbientOcclusion m_Settings;

	private readonly RenderTargetIdentifier[] m_MRT;

	private readonly int[] m_SampleCount;

	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	public ScalableAO(AmbientOcclusion settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAmbientOnly")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(ScalableAO), Member = "DoLazyInitialization")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	public void Release()
	{
	}
}
