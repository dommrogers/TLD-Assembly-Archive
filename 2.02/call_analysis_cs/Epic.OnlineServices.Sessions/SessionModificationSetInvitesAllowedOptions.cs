using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionModificationSetInvitesAllowedOptions
{
	private bool _003CInvitesAllowed_003Ek__BackingField;

	public bool InvitesAllowed
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SessionModificationSetInvitesAllowedOptions()
	{
	}
}
