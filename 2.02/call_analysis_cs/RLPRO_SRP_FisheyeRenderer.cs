using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_FisheyeRenderer : PostProcessEffectRenderer<RLProFisheye>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallsUnknownMethods(Count = 1)]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RLPRO_SRP_FisheyeRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
