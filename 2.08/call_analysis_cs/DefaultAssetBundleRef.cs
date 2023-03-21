using System;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DefaultAssetBundleRef : AssetBundleRef
{
	private enum State
	{
		Created,
		Loading,
		Ready
	}

	private AssetBundle m_Bundle;

	private AssetBundleCreateRequest m_Request;

	private State m_State;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DefaultAssetBundleRef(string name)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Format")]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(AssetBundleRef), Member = "IsLoaded")]
	[CallerCount(Count = 0)]
	public override bool IsLoaded()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override float GetProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Contains(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[Calls(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal override void LoadBundle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[CallsUnknownMethods(Count = 1)]
	internal override void LoadBundleAsync()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public override UnityEngine.Object[] LoadAllAssets()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor")]
	public override UnityEngine.Object[] LoadAllAssets(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override T[] LoadAllAssets<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[CallsUnknownMethods(Count = 1)]
	public override UnityEngine.Object LoadAsset(string name)
	{
		return null;
	}

	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	public override UnityEngine.Object LoadAsset(string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[CallsUnknownMethods(Count = 1)]
	public override T LoadAsset<T>(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	public override AssetBundleRefRequest LoadAssetAsync(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public override AssetBundleRefRequest LoadAssetAsync(string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public override AssetBundleRefRequest LoadAssetAsync<T>(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[CallerCount(Count = 3)]
	internal string CorrectAssetName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal override bool UpdateBundleLoad()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static bool DoesBundleExist(string bundleName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "DoesBundleExist")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 4)]
	private static string GetFullBundlePath(string bundleName)
	{
		return null;
	}
}
