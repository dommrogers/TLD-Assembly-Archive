using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct SessionDetailsSettingsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_BucketId;

	private uint m_NumPublicConnections;

	private int m_AllowJoinInProgress;

	private OnlineSessionPermissionLevel m_PermissionLevel;

	private int m_InvitesAllowed;

	public string BucketId
	{
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint NumPublicConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AllowJoinInProgress
	{
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public OnlineSessionPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(OnlineSessionPermissionLevel);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool InvitesAllowed
	{
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return false;
		}
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_BucketId")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_AllowJoinInProgress")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_InvitesAllowed")]
	public void Set(SessionDetailsSettings other)
	{
	}

	[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_BucketId")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_AllowJoinInProgress")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_InvitesAllowed")]
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
