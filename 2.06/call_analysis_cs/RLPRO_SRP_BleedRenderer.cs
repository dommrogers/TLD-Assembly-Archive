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
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[CallsUnknownMethods(Count = 1)]
	public override void Init()
	{
	}

	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Curves")]
	[CallsUnknownMethods(Count = 1)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertySheet), Member = "DisableKeyword")]
	[DeduplicatedMethod]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Init")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	private void Curves()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RLPRO_SRP_BleedRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
