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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	public override void Init()
	{
	}

	[Calls(Type = typeof(Color), Member = "get_linear")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessDebugLayer), Member = "PushDebugOverlay")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 84)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_blackTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "Log")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BloomRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
