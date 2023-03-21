using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DefaultHDRHandler : IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetPaperWhiteNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetPeakBrightnessNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOutputtingHDR()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DefaultHDRHandler()
	{
	}
}
