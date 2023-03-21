using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.UI;

public interface IAccelerateTimeProvider
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool IsAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string GetActionText();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string GetSpriteName();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	UIPanel GetPanelToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	UIWidget GetWidgetToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Action GetCancelAction();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	UIProgressBar GetActionProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void StartAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void StopAcceleratingTime();
}
