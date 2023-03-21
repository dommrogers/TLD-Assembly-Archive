using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Metrics;

public class BeginPlayerSessionOptions
{
	private BeginPlayerSessionOptionsAccountId _003CAccountId_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private UserControllerType _003CControllerType_003Ek__BackingField;

	private string _003CServerIp_003Ek__BackingField;

	private string _003CGameSessionId_003Ek__BackingField;

	public BeginPlayerSessionOptionsAccountId AccountId
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

	public string DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public UserControllerType ControllerType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(UserControllerType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string ServerIp
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

	public string GameSessionId
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BeginPlayerSessionOptions()
	{
	}
}
