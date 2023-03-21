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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Panel_Base> m_PanelInstantiatedCallback
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

	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	public BaseLoadPanelRequest(string panelName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void NotifyPanelLoaded()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
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

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public string GetError()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UpdateRequest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Addressables), Member = "ReleaseInstance")]
	[CallsUnknownMethods(Count = 2)]
	public void CleanupRequest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
