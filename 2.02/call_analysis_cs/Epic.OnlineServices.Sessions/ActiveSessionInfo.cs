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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_SessionName")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_LocalUserId")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "get_SessionDetails")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(ActiveSessionInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ActiveSessionInfo()
	{
	}
}
