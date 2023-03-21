using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionModificationSetJoinInProgressAllowedOptions
{
	private bool _003CAllowJoinInProgress_003Ek__BackingField;

	public bool AllowJoinInProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionModificationSetJoinInProgressAllowedOptions()
	{
	}
}
