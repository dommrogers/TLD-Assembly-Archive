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
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Uri ExtendedInfoUrl
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public InAppRewardValueList InAppRewardValue
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AchievementNotification._003CGetEnumerator_003Ed__9), Member = "MoveNext")]
		[CalledBy(Type = typeof(AchievementNotification._003CGetEnumerator_003Ed__9), Member = "MoveNext")]
		[CalledBy(Type = typeof(AchievementNotification), Member = "get_Length")]
		[CalledBy(Type = typeof(AchievementNotification), Member = "get_Item")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string ServiceConfigurationId
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
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
		[CallsUnknownMethods(Count = 6)]
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
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return default(DateTime);
		}
	}

	public uint UserId
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
	}

	public string XboxUserId
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
	public AchievementUnlockedEventArgs()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	~AchievementUnlockedEventArgs()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
