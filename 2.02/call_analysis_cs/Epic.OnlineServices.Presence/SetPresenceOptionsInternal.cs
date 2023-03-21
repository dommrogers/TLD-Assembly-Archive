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
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public PresenceModification PresenceModificationHandle
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
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

	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "SetPresence")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "set_PresenceModificationHandle")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
