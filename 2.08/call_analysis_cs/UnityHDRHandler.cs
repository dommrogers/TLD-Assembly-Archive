using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnityHDRHandler : IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[CalledBy(Type = typeof(UnityHDRHandler), Member = "Initialize")]
	[CalledBy(Type = typeof(UnityHDRHandler), Member = "SetPaperWhiteNits")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsOutputtingHDR()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetPaperWhiteNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SetPeakBrightnessNits(float value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public UnityHDRHandler()
	{
	}
}
