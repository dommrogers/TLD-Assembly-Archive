using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public interface IHDRHandler
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SetPaperWhiteNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SetPeakBrightnessNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool IsOutputtingHDR();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void Render(RenderTexture source, RenderTexture destination);
}
