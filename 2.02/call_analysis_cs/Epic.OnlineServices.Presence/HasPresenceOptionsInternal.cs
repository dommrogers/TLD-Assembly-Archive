using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct HasPresenceOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(HasPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(HasPresenceOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(HasPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(HasPresenceOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HasPresenceOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(HasPresenceOptionsInternal), Member = "set_TargetUserId")]
	public void Set(HasPresenceOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceInterface), Member = "HasPresence")]
	[Calls(Type = typeof(HasPresenceOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HasPresenceOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
