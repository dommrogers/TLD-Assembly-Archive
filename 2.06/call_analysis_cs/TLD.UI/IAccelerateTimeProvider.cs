using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.UI;

public interface IAccelerateTimeProvider
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool IsAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	string GetActionText();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	string GetSpriteName();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	UIPanel GetPanelToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	UIWidget GetWidgetToFade();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Action GetCancelAction();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	UIProgressBar GetActionProgress();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void StartAcceleratingTime();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void StopAcceleratingTime();
}
