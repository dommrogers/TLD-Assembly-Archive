using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public interface IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetPaperWhiteNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetPeakBrightnessNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool IsOutputtingHDR();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Render(RenderTexture source, RenderTexture destination);
}
