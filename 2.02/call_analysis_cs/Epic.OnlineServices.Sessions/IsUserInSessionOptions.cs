using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class IsUserInSessionOptions
{
	private string _003CSessionName_003Ek__BackingField;

	private ProductUserId _003CTargetUserId_003Ek__BackingField;

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

	public ProductUserId TargetUserId
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public IsUserInSessionOptions()
	{
	}
}
