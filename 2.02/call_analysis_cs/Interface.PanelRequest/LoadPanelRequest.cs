using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Interface.PanelRequest;

public class LoadPanelRequest : BaseLoadPanelRequest
{
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public LoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private GameObject LoadAssetBundle(string bundleName, string panelVariantName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 1)]
	private GameObject LoadPanelFromResources(string panelVariantName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return 0f;
	}
}
