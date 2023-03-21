using System;
using Cpp2ILInjected.CallAnalysis;

namespace Interface.PanelRequest;

public interface ILoadPanelRequest
{
	event Action<bool> m_PanelLoadedCallback;

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool IsLoadingPanel(string panelName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void NotifyPanelLoaded();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	float GetProgress();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	bool HasCompleted();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool HasFailed();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	string GetError();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void UpdateRequest();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void CleanupRequest();
}
