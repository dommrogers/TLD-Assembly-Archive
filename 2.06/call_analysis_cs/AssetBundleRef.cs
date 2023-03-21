using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRef
{
	protected List<AssetBundleRef> m_Dependencies;

	protected readonly string m_Name;

	protected readonly int m_NameHash;

	protected int m_RefCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected AssetBundleRef(string name)
	{
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "IsLoaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool IsLoaded()
	{
		return false;
	}

	public abstract float GetProgress();

	public abstract bool IsValid();

	public abstract bool Contains(string name);

	public abstract UnityEngine.Object LoadAsset(string name);

	public abstract UnityEngine.Object LoadAsset(string name, Type type);

	public abstract T LoadAsset<T>(string name) where T : UnityEngine.Object;

	public abstract UnityEngine.Object[] LoadAllAssets();

	public abstract UnityEngine.Object[] LoadAllAssets(Type type);

	public abstract T[] LoadAllAssets<T>() where T : UnityEngine.Object;

	public abstract AssetBundleRefRequest LoadAssetAsync(string name);

	public abstract AssetBundleRefRequest LoadAssetAsync(string name, Type type);

	public abstract AssetBundleRefRequest LoadAssetAsync<T>(string name) where T : UnityEngine.Object;

	internal abstract bool UpdateBundleLoad();

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void LoadBundle()
	{
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void LoadBundleAsync()
	{
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "UnloadBundle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public override int GetHashCode()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 53)]
	public string GetName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public int GetRefCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public bool HasDependencies()
	{
		return false;
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal void AddDependent(AssetBundleRef bundle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	internal int DecrementRefCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	internal int IncrementRefCount()
	{
		return 0;
	}
}
