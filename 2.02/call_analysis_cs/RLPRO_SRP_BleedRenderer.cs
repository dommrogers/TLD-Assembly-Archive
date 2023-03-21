using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public sealed class RLPRO_SRP_BleedRenderer : PostProcessEffectRenderer<RLProBleed>
{
	public AnimationCurve cu;

	private int max_curve_length;

	private Texture2D texCurves;

	private Vector4 curvesOffest;

	private float[,] curvesData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[CallsUnknownMethods(Count = 2)]
	public override void Init()
	{
	}

	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Init")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	[Calls(Type = typeof(Vector4), Member = "get_Item")]
	[CallsUnknownMethods(Count = 92)]
	[Calls(Type = typeof(Vector4), Member = "get_Item")]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	private void Curves()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public RLPRO_SRP_BleedRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
