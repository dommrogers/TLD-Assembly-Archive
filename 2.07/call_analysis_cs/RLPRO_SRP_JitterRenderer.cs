using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_JitterRenderer : PostProcessEffectRenderer<RLProJitter>
{
	private float start;

	private float _time;

	private bool once;

	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CallerCount(Count = 0)]
	public RLPRO_SRP_JitterRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
