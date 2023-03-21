using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
internal sealed class Dithering
{
	private int m_NoiseTextureIndex;

	private System.Random m_Random;

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Random), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Dithering()
	{
	}
}
