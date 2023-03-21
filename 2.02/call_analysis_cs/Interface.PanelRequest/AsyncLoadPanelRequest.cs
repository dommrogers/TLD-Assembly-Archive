using System;
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 1)]
	public AsyncLoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override float GetProgress()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override void UpdateRequest_Internal()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	private void UpdateAssetBundleRequest()
	{
	}

	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	private void UpdateAssetBundlePanelRequest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "FinishLoadRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "SetRequestFailed")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateResourcesRequest()
	{
	}
}
