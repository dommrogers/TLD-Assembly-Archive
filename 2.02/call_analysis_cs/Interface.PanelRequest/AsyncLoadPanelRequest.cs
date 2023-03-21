using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Interface.PanelRequest;

public class AsyncLoadPanelRequest : BaseLoadPanelRequest
{
	private AssetBundleRef m_AssetBundleRequest;

	private AssetBundleRefRequest m_AssetBundlePanelRequest;

	private ResourceRequest m_ResourceRequest;

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(Resources), Member = "LoadAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override float GetProgress()
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void UpdateRequest_Internal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 29)]
	private void UpdateAssetBundleRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateAssetBundlePanelRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateResourcesRequest()
	{
	}
}
