using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class AchievementMediaAsset : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private string m_Name;

	private string m_Url;

	public AchievementMediaAssetType MediaAssetType
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(AchievementMediaAssetType);
		}
	}

	public string Name
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string Url
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AchievementMediaAsset(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public AchievementMediaAsset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 98)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	~AchievementMediaAsset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
