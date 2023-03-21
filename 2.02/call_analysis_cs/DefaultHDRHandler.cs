using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DefaultHDRHandler : IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetPaperWhiteNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetPeakBrightnessNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOutputtingHDR()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DefaultHDRHandler()
	{
	}
}
