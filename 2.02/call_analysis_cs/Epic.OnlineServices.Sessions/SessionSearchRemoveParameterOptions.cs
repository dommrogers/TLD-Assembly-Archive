using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class SessionSearchRemoveParameterOptions
{
	private string _003CKey_003Ek__BackingField;

	private ComparisonOp _003CComparisonOp_003Ek__BackingField;

	public string Key
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

	public ComparisonOp ComparisonOp
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(ComparisonOp);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SessionSearchRemoveParameterOptions()
	{
	}
}
