using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class SubpixelMorphologicalAntialiasing
{
	private enum Pass
	{
		EdgeDetection = 0,
		BlendWeights = 3,
		NeighborhoodBlending = 6
	}

	public enum Quality
	{
		Low,
		Medium,
		High
	}

	public Quality quality;

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsSupported()
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 22)]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public SubpixelMorphologicalAntialiasing()
	{
	}
}
