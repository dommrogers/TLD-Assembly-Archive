using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionDetailsSettings : ISettable
{
	private string _003CBucketId_003Ek__BackingField;

	private uint _003CNumPublicConnections_003Ek__BackingField;

	private bool _003CAllowJoinInProgress_003Ek__BackingField;

	private OnlineSessionPermissionLevel _003CPermissionLevel_003Ek__BackingField;

	private bool _003CInvitesAllowed_003Ek__BackingField;

	public string BucketId
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public uint NumPublicConnections
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool AllowJoinInProgress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public OnlineSessionPermissionLevel PermissionLevel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(OnlineSessionPermissionLevel);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool InvitesAllowed
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_InvitesAllowed")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_AllowJoinInProgress")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_BucketId")]
	internal void Set(SessionDetailsSettingsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_BucketId")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_AllowJoinInProgress")]
	[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "get_InvitesAllowed")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionDetailsSettings()
	{
	}
}
