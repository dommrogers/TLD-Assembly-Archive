using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

public class OnFriendsUpdateInfo : ICallbackInfo, ISettable
{
	private object _003CClientData_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private EpicAccountId _003CTargetUserId_003Ek__BackingField;

	private FriendsStatus _003CPreviousStatus_003Ek__BackingField;

	private FriendsStatus _003CCurrentStatus_003Ek__BackingField;

	public object ClientData
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public EpicAccountId TargetUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		private set
		{
		}
	}

	public FriendsStatus PreviousStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FriendsStatus);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public FriendsStatus CurrentStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FriendsStatus);
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

	[CalledBy(Type = typeof(OnFriendsUpdateInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(OnFriendsUpdateInfoInternal), Member = "get_TargetUserId")]
	[Calls(Type = typeof(OnFriendsUpdateInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(OnFriendsUpdateInfoInternal), Member = "get_ClientData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void Set(OnFriendsUpdateInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OnFriendsUpdateInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public OnFriendsUpdateInfo()
	{
	}
}
