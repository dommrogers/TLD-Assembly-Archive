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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	public event Action<Panel_Base> m_PanelInstantiatedCallback
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 51)]
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
	[CallerCount(Count = 101224)]
	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCompleted()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Type GetPanelType()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[CallsUnknownMethods(Count = 3)]
	public Panel_Base GetPanel()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasFailed()
	{
		return default(bool);
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string GetError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateRequest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
