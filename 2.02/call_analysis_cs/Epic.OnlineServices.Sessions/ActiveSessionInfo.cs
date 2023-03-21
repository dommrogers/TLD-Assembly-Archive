using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class ActiveSessionInfo : ISettable
{
	private string _003CSessionName_003Ek__BackingField;

	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private OnlineSessionState _003CState_003Ek__BackingField;

	private SessionDetailsInfo _003CSessionDetails_003Ek__BackingField;

	public string SessionName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
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

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public OnlineSessionState State
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(OnlineSessionState);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public SessionDetailsInfo SessionDetails
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_SessionDetails")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_SessionName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void Set(ActiveSessionInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActiveSessionInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ActiveSessionInfo()
	{
	}
}
