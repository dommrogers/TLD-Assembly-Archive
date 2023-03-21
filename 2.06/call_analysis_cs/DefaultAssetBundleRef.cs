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

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetBundleRef), Member = "IsLoaded")]
	public override bool IsLoaded()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public override float GetProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	internal override void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[Calls(Type = typeof(AssetBundle), Member = "LoadAllAssets")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override UnityEngine.Object[] LoadAllAssets()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAllAssets")]
	[CallsUnknownMethods(Count = 1)]
	public override UnityEngine.Object[] LoadAllAssets(Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public override T[] LoadAllAssets<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[CallsUnknownMethods(Count = 1)]
	public override UnityEngine.Object LoadAsset(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[CallerCount(Count = 0)]
	public override UnityEngine.Object LoadAsset(string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[CallsUnknownMethods(Count = 1)]
	public override T LoadAsset<T>(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public override AssetBundleRefRequest LoadAssetAsync(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public override AssetBundleRefRequest LoadAssetAsync(string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public override AssetBundleRefRequest LoadAssetAsync<T>(string name)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	internal string CorrectAssetName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "DoesBundleExist")]
	private static string GetFullBundlePath(string bundleName)
	{
		return null;
	}
}
