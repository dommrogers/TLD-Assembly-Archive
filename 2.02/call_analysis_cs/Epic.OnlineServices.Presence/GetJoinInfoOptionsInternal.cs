using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetJoinInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetJoinInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetJoinInfoOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(GetJoinInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetJoinInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetJoinInfoOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetJoinInfoOptionsInternal), Member = "set_TargetUserId")]
	public void Set(GetJoinInfoOptions other)
	{
	}

	[Calls(Type = typeof(GetJoinInfoOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetJoinInfoOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "GetJoinInfo")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
