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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	public BatchAsyncLoadPanelRequest(List<Type> panelTypes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool IsLoadingPanel(string panelName)
	{
		return false;
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCompleted()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public bool HasFailed()
	{
		return false;
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

	[CalledBy(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void LoadNextPanel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void CleanupRequest()
	{
	}
}
