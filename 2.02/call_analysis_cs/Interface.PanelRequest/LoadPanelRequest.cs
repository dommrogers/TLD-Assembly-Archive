using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Interface.PanelRequest;

public class LoadPanelRequest : BaseLoadPanelRequest
{
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[CallsUnknownMethods(Count = 7)]
	public LoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private GameObject LoadAssetBundle(string bundleName, string panelVariantName)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private GameObject LoadPanelFromResources(string panelVariantName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return default(float);
	}
}
