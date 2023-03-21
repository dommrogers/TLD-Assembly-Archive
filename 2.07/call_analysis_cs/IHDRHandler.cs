using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public interface IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void SetPaperWhiteNits(float value);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void SetPeakBrightnessNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool IsOutputtingHDR();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Render(RenderTexture source, RenderTexture destination);
}
