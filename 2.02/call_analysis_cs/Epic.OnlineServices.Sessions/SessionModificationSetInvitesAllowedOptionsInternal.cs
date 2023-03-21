using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct SessionModificationSetInvitesAllowedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_InvitesAllowed;

	public bool InvitesAllowed
	{
		[CalledBy(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "set_InvitesAllowed")]
	public void Set(SessionModificationSetInvitesAllowedOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionModification), Member = "SetInvitesAllowed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionModificationSetInvitesAllowedOptionsInternal), Member = "set_InvitesAllowed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
