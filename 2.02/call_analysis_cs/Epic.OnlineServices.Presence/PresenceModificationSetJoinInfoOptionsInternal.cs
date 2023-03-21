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
		[CalledBy(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "set_JoinInfo")]
	public void Set(PresenceModificationSetJoinInfoOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceModification), Member = "SetJoinInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PresenceModificationSetJoinInfoOptionsInternal), Member = "set_JoinInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
