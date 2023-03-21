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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[CallsUnknownMethods(Count = 2)]
	public ScalableAO(AmbientOcclusion settings)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[CallsUnknownMethods(Count = 5)]
	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAmbientOnly")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(ScalableAO), Member = "DoLazyInitialization")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public void Release()
	{
	}
}
