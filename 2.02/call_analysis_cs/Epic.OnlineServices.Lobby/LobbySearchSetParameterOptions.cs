using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbySearchSetParameterOptions
{
	private AttributeData _003CParameter_003Ek__BackingField;

	private ComparisonOp _003CComparisonOp_003Ek__BackingField;

	public AttributeData Parameter
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
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

	public ComparisonOp ComparisonOp
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(ComparisonOp);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbySearchSetParameterOptions()
	{
	}
}
