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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	public BatchAsyncLoadPanelRequest(List<Type> panelTypes)
	{
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
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
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = ".ctor")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void LoadNextPanel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void CleanupRequest()
	{
	}
}
