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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AssetBundleRef), Member = "HasDependencies")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override float GetProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override bool IsValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool Contains(string name)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	internal override void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAllAssets")]
	public override UnityEngine.Object[] LoadAllAssets()
	{
		return null;
	}

	[Calls(Type = typeof(AssetBundle), Member = "LoadAllAssets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override UnityEngine.Object[] LoadAllAssets(Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override T[] LoadAllAssets<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	public override UnityEngine.Object LoadAsset(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override UnityEngine.Object LoadAsset(string name, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "CorrectAssetName")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override T LoadAsset<T>(string name)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	public override AssetBundleRefRequest LoadAssetAsync(string name)
	{
		return null;
	}

	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public override AssetBundleRefRequest LoadAssetAsync(string name, Type type)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRefRequest), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[DeduplicatedMethod]
	public override AssetBundleRefRequest LoadAssetAsync<T>(string name)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadAsset")]
	internal string CorrectAssetName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal override bool UpdateBundleLoad()
	{
		return default(bool);
	}

	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[CallerCount(Count = 0)]
	public static bool DoesBundleExist(string bundleName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "DoesBundleExist")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "BundleExists")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static string GetFullBundlePath(string bundleName)
	{
		return null;
	}
}
