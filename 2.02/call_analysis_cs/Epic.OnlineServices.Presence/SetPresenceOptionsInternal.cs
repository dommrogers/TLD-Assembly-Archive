using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SetPresenceOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_PresenceModificationHandle;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public PresenceModification PresenceModificationHandle
	{
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_PresenceModificationHandle")]
	public void Set(SetPresenceOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceInterface), Member = "SetPresence")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_PresenceModificationHandle")]
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
