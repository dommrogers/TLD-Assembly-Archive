using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyPresenceOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyPresenceOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyPresenceOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyPresenceOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyPresenceOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyPresenceOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyPresenceOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyPresenceOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(PresenceInterface), Member = "CopyPresence")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
