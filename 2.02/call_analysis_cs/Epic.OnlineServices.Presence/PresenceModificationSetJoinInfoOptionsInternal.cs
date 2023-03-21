using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct PresenceModificationSetJoinInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_JoinInfo;

	public string JoinInfo
	{
		[CalledBy(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "set_JoinInfo")]
	public void Set(PresenceModificationSetJoinInfoOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "set_JoinInfo")]
	[CalledBy(Type = typeof(PresenceModification), Member = "SetJoinInfo")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
