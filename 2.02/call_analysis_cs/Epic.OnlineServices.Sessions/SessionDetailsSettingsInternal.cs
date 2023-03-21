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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
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
			return default(uint);
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
			return default(bool);
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		set
		{
		}
	}

	public OnlineSessionPermissionLevel PermissionLevel
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettings), Member = "Set")]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_BucketId")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_AllowJoinInProgress")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "set_InvitesAllowed")]
	[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
