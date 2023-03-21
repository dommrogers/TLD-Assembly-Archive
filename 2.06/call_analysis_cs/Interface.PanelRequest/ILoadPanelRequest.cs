using System;

namespace Interface.PanelRequest;

public interface ILoadPanelRequest
{
	event Action<bool> m_PanelLoadedCallback;

	bool IsLoadingPanel(string panelName);

	void NotifyPanelLoaded();

	float GetProgress();

	bool HasCompleted();

	bool HasFailed();

	string GetError();

	void UpdateRequest();

	void CleanupRequest();
}
