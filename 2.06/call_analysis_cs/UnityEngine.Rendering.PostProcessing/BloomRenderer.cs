using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
{
	private enum Pass
	{
		Prefilter13,
		Prefilter4,
		Downsample13,
		Downsample4,
		UpsampleTent,
		UpsampleBox,
		DebugOverlayThreshold,
		DebugOverlayTent,
		DebugOverlayBox
	}

	private struct Level
	{
		internal int down;

		internal int up;
	}

	private Level[] m_Pyramid;

	private const int k_MaxPyramidSize = 16;

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public override void Init()
	{
	}

	[Calls(Type = typeof(Color), Member = "get_linear")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_blackTexture")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public BloomRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
