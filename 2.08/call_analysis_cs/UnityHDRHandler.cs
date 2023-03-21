using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UnityHDRHandler : IHDRHandler
{
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UnityHDRHandler), Member = "Initialize")]
	[CalledBy(Type = typeof(UnityHDRHandler), Member = "SetPaperWhiteNits")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsOutputtingHDR()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityHDRHandler), Member = "IsOutputtingHDR")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
