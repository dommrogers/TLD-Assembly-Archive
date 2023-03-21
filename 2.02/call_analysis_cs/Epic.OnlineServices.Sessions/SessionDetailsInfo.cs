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

	public string HostAddress
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

	public uint NumOpenPublicConnections
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0u;
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
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_SessionId")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_HostAddress")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "get_Settings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(SessionDetailsInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsInfo), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SessionDetailsInfo()
	{
	}
}
