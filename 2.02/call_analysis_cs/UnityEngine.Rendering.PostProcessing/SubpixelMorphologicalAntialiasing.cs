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

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isSinglePassStereoEnabled")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsSupported()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public SubpixelMorphologicalAntialiasing()
	{
	}
}
