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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	public BatchAsyncLoadPanelRequest(List<Type> panelTypes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void NotifyPanelLoaded()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCompleted()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasFailed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void UpdateRequest()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "HasCompleted")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	private void LoadNextPanel()
	{
	}
}
