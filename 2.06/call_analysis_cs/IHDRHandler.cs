using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public interface IHDRHandler
{
	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void SetPaperWhiteNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void SetPeakBrightnessNits(float value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool IsOutputtingHDR();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void Render(RenderTexture source, RenderTexture destination);
}
