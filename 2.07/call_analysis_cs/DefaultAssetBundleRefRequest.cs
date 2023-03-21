using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal class DefaultAssetBundleRefRequest : AssetBundleRefRequest
{
	private AssetBundleRequest m_Request;

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAssetAsync")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAssetAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAssetAsync")]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override T GetObject<T>()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool IsLoaded()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return default(float);
	}
}
