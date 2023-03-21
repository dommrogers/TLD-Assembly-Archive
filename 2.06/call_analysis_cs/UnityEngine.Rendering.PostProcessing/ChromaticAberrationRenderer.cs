using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
{
	private Texture2D m_InternalSpectralLut;

	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	public ChromaticAberrationRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
