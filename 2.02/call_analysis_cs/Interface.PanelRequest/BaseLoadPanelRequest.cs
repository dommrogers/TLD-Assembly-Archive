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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<Panel_Base> m_PanelInstantiatedCallback
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public BaseLoadPanelRequest(string panelName)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	public bool IsLoadingPanel(string panelName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void NotifyPanelLoaded()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 2)]
	protected virtual void UpdateRequest_Internal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateResourcesRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundlePanelRequest")]
	[CallerCount(Count = 3)]
	protected void FinishLoadRequest(GameObject panelObject)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundleRequest")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundlePanelRequest")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateResourcesRequest")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	protected void SetRequestFailed(string errorMessage)
	{
	}
}
