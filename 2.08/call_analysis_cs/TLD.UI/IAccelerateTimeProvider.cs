using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.UI;

public interface IAccelerateTimeProvider
{
	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	bool IsAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	string GetActionText();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	string GetSpriteName();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	UIPanel GetPanelToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	UIWidget GetWidgetToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Action GetCancelAction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	UIProgressBar GetActionProgress();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void StartAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void StopAcceleratingTime();
}
