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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "IsLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public virtual bool IsLoaded()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract bool IsValid();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract bool Contains(string name);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract UnityEngine.Object LoadAsset(string name);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract UnityEngine.Object LoadAsset(string name, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract T LoadAsset<T>(string name) where T : UnityEngine.Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract UnityEngine.Object[] LoadAllAssets();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract UnityEngine.Object[] LoadAllAssets(Type type);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract T[] LoadAllAssets<T>() where T : UnityEngine.Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract AssetBundleRefRequest LoadAssetAsync(string name, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract AssetBundleRefRequest LoadAssetAsync<T>(string name) where T : UnityEngine.Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	internal abstract bool UpdateBundleLoad();

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundle")]
	[CallsUnknownMethods(Count = 8)]
	internal virtual void LoadBundle()
	{
	}

	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleRef), Member = "AddDependent")]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetDependencies")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal virtual void LoadBundleAsync()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(DefaultAssetBundleRef), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void UnloadBundle(bool unloadAllLoadedObjects)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public string GetName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public int GetRefCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public bool HasDependencies()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 2)]
	internal void AddDependent(AssetBundleRef bundle)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
