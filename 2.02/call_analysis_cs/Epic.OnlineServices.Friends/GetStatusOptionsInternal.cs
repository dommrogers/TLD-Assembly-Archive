using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetStatusOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetStatusOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetStatusOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetStatusOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetStatusOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetStatusOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetStatusOptionsInternal), Member = "set_TargetUserId")]
	public void Set(GetStatusOptions other)
	{
	}

	[CalledBy(Type = typeof(FriendsInterface), Member = "GetStatus")]
	[Calls(Type = typeof(GetStatusOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetStatusOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
