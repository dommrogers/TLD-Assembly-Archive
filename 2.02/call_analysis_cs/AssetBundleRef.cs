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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AssetBundleRef(string name)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetBundleRef), Member = "HasDependencies")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "IsLoaded")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public virtual bool IsLoaded()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract float GetProgress();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract bool IsValid();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract bool Contains(string name);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract UnityEngine.Object LoadAsset(string name);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract UnityEngine.Object LoadAsset(string name, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract T LoadAsset<T>(string name) where T : UnityEngine.Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract UnityEngine.Object[] LoadAllAssets();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract UnityEngine.Object[] LoadAllAssets(Type type);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract T[] LoadAllAssets<T>() where T : UnityEngine.Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract AssetBundleRefRequest LoadAssetAsync<T>(string name) where T : UnityEngine.Object;

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	internal abstract bool UpdateBundleLoad();

	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	internal virtual void LoadBundle()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void LoadBundleAsync()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AssetBundleRef), Member = "HasDependencies")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public string GetName()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int GetRefCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "GetProgress")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "IsLoaded")]
	public bool HasDependencies()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CallerCount(Count = 2)]
	internal void AddDependent(AssetBundleRef bundle)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal int DecrementRefCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	internal int IncrementRefCount()
	{
		return default(int);
	}
}
