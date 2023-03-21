using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLProUltimateVignetteRenderer : PostProcessEffectRenderer<RLProUltimateVignette>
{
	private float m_Horizontal;

	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public RLProUltimateVignetteRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
