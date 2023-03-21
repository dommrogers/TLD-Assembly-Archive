using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct OnFriendsUpdateInfoInternal : ICallbackInfoInternal
{
	private IntPtr m_ClientData;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private FriendsStatus m_PreviousStatus;

	private FriendsStatus m_CurrentStatus;

	public object ClientData
	{
		[CalledBy(Type = typeof(OnFriendsUpdateInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IntPtr ClientDataAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (IntPtr)0;
		}
	}

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(OnFriendsUpdateInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(OnFriendsUpdateInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public FriendsStatus PreviousStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(FriendsStatus);
		}
	}

	public FriendsStatus CurrentStatus
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FriendsStatus);
		}
	}
}
