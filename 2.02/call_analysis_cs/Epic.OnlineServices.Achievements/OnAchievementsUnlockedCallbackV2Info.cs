using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class OnAchievementsUnlockedCallbackV2Info : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CUserId_003Ek__BackingField;

	private string _003CAchievementId_003Ek__BackingField;

	private DateTimeOffset? _003CUnlockTime_003Ek__BackingField;

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	public ProductUserId UserId
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	public string AchievementId
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public DateTimeOffset? UnlockTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Result? GetResultCode()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2InfoInternal), Member = "get_UserId")]
	internal void Set(OnAchievementsUnlockedCallbackV2InfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnAchievementsUnlockedCallbackV2Info), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnAchievementsUnlockedCallbackV2Info()
	{
	}
}
