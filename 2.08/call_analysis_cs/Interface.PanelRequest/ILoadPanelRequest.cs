using System;
using Cpp2ILInjected.CallAnalysis;

namespace Interface.PanelRequest;

public interface ILoadPanelRequest
{
	event Action<bool> m_PanelLoadedCallback;

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	bool IsLoadingPanel(string panelName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void NotifyPanelLoaded();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool HasCompleted();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	bool HasFailed();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	string GetError();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void UpdateRequest();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void CleanupRequest();
}
