using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal class DefaultAssetBundleRefRequest : AssetBundleRefRequest
{
	private AssetBundleRequest m_Request;

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAssetAsync")]
	[CallsUnknownMethods(Count = 1)]
	public DefaultAssetBundleRefRequest(AssetBundle bundle, string name, Type type = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override UnityEngine.Object GetObject()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public override T GetObject<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsLoaded()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override float GetProgress()
	{
		return 0f;
	}
}
