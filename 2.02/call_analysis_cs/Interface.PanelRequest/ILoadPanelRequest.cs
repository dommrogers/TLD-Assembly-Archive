using System;
using Cpp2ILInjected.CallAnalysis;

namespace Interface.PanelRequest;

public interface ILoadPanelRequest
{
	event Action<bool> m_PanelLoadedCallback;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool IsLoadingPanel(string panelName);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void NotifyPanelLoaded();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool HasCompleted();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool HasFailed();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	string GetError();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void UpdateRequest();
}
