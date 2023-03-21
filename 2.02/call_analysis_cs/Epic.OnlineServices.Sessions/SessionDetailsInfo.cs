using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionDetailsInfo : ISettable
{
	private string _003CSessionId_003Ek__BackingField;

	private string _003CHostAddress_003Ek__BackingField;

	private uint _003CNumOpenPublicConnections_003Ek__BackingField;

	private SessionDetailsSettings _003CSettings_003Ek__BackingField;

	public string SessionId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string HostAddress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public uint NumOpenPublicConnections
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	public SessionDetailsSettings Settings
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
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_Settings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_SessionId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_HostAddress")]
	internal void Set(SessionDetailsInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SessionDetailsInfo()
	{
	}
}
