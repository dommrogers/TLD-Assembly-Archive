using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Interface.PanelRequest;

public class BatchAsyncLoadPanelRequest : ILoadPanelRequest
{
	private List<Type> m_PanelTypes;

	private ILoadPanelRequest m_CurrentRequest;

	private int m_CurrentIndex;

	public event Action<bool> m_PanelLoadedCallback
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallerCount(Count = 0)]
	public BatchAsyncLoadPanelRequest(List<Type> panelTypes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void NotifyPanelLoaded()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCompleted()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public bool HasFailed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public string GetError()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UpdateRequest()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	private void LoadNextPanel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void CleanupRequest()
	{
	}
}
