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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "Init")]
	[CallsUnknownMethods(Count = 5)]
	public ScalableAO(AmbientOcclusion settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTexture), Member = "Release")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAmbientOnly")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(ScalableAO), Member = "DoLazyInitialization")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScalableAO), Member = "Render")]
	[CallsUnknownMethods(Count = 4)]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 5)]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Release()
	{
	}
}
