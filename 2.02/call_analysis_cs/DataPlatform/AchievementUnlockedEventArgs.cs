using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class AchievementUnlockedEventArgs : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private string m_AchievementId;

	private Uri m_ExtendedInfoUrl;

	private InAppRewardValueList m_InAppRewardValue;

	private string m_ServiceConfigurationId;

	private string m_TitleId;

	private DateTime m_UnlockTime;

	public string AchievementId
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(AchievementNotification), Member = "get_AchievementId")]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public Uri ExtendedInfoUrl
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public InAppRewardValueList InAppRewardValue
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(AchievementNotification), Member = "get_Length")]
		[CalledBy(Type = typeof(AchievementNotification), Member = "get_Item")]
		[CalledBy(Type = typeof(AchievementNotification._003CGetEnumerator_003Ed__9), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string ServiceConfigurationId
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string TitleId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public DateTime UnlockTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedDateTime")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return default(DateTime);
		}
	}

	public uint UserId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public string XboxUserId
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalString")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AchievementUnlockedEventArgs(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AchievementUnlockedEventArgs()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 52)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	~AchievementUnlockedEventArgs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
