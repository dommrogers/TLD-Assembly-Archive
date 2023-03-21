using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Interface.PanelRequest;

public abstract class BaseLoadPanelRequest : ILoadPanelRequest
{
	protected const string ASSETBUNDLE_PATH_FORMAT = "ui/panel/{0}";

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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<Panel_Base> m_PanelInstantiatedCallback
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public BaseLoadPanelRequest(string panelName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public bool IsLoadingPanel(string panelName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void NotifyPanelLoaded()
	{
	}

	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCompleted()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Type GetPanelType()
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_Base GetPanel()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasFailed()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetError()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateRequest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void UpdateRequest_Internal()
	{
	}

	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundlePanelRequest")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateResourcesRequest")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void FinishLoadRequest(GameObject panelObject)
	{
	}

	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundleRequest")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundlePanelRequest")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateResourcesRequest")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[CallerCount(Count = 4)]
	protected void SetRequestFailed(string errorMessage)
	{
	}
}
