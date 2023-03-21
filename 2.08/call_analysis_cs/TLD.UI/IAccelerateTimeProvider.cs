using System;

namespace TLD.UI;

public interface IAccelerateTimeProvider
{
	bool IsAcceleratingTime();

	string GetActionText();

	string GetSpriteName();

	UIPanel GetPanelToFade();

	UIWidget GetWidgetToFade();

	Action GetCancelAction();

	UIProgressBar GetActionProgress();

	void StartAcceleratingTime();

	void StopAcceleratingTime();
}
