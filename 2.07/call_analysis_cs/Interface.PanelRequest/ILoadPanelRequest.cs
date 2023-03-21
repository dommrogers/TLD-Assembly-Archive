using System;
using Cpp2ILInjected.CallAnalysis;

namespace Interface.PanelRequest;

public interface ILoadPanelRequest
{
	event Action<bool> m_PanelLoadedCallback;

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool IsLoadingPanel(string panelName);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void NotifyPanelLoaded();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool HasCompleted();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool HasFailed();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string GetError();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void UpdateRequest();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void CleanupRequest();
}
