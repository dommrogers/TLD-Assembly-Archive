using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnityHDRHandler : IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UnityHDRHandler), Member = "Initialize")]
	[CalledBy(Type = typeof(UnityHDRHandler), Member = "SetPaperWhiteNits")]
	public bool IsOutputtingHDR()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallerCount(Count = 0)]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
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
