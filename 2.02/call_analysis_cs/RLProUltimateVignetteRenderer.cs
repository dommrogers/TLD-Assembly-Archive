using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLProUltimateVignetteRenderer : PostProcessEffectRenderer<RLProUltimateVignette>
{
	private float m_Horizontal;

	[Calls(Type = typeof(Vector2Parameter), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RLProUltimateVignetteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
