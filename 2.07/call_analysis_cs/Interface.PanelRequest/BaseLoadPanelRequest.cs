using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Interface.PanelRequest;

public abstract class BaseLoadPanelRequest : ILoadPanelRequest
{
	protected string m_PanelName;

	private bool m_IsCompleted;

	private Panel_Base m_PanelResource;

	private Panel_Base m_InstantiatedPanel;

	private string m_ErrorMessage;

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

	public event Action<Panel_Base> m_PanelInstantiatedCallback
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public BaseLoadPanelRequest(string panelName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void NotifyPanelLoaded()
	{
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCompleted()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Type GetPanelType()
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	public Panel_Base GetPanel()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasFailed()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public string GetError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateRequest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Addressables), Member = "ReleaseInstance")]
	public void CleanupRequest()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void UpdateRequest_Internal()
	{
	}

	[CallerCount(Count = 0)]
	protected void FinishLoadRequest(Panel_Base panelObject)
	{
	}

	[CallerCount(Count = 0)]
	protected void SetRequestFailed(string errorMessage)
	{
	}
}
