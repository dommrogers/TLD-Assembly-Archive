using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class OnUnlockAchievementsCompleteCallbackInfo : ICallbackInfo, ISettable
{
	private Result _003CResultCode_003Ek__BackingField;

	private object _003CClientData_003Ek__BackingField;

	private ProductUserId _003CUserId_003Ek__BackingField;

	private uint _003CAchievementsCount_003Ek__BackingField;

	public Result ResultCode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(Result);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public object ClientData
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	public ProductUserId UserId
	{
		[CompilerGenerated]
		[CallerCount(Count = 5)]
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

	public uint AchievementsCount
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Result? GetResultCode()
	{
		return null;
	}

	[Calls(Type = typeof(OnUnlockAchievementsCompleteCallbackInfoInternal), Member = "get_ClientData")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(OnUnlockAchievementsCompleteCallbackInfoInternal), Member = "get_UserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal void Set(OnUnlockAchievementsCompleteCallbackInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(OnUnlockAchievementsCompleteCallbackInfoInternal), Member = "get_ClientData")]
	[Calls(Type = typeof(OnUnlockAchievementsCompleteCallbackInfoInternal), Member = "get_UserId")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnUnlockAchievementsCompleteCallbackInfo()
	{
	}
}
