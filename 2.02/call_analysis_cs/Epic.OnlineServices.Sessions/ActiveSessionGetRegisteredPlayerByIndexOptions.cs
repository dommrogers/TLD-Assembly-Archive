using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class ActiveSessionGetRegisteredPlayerByIndexOptions
{
	private uint _003CPlayerIndex_003Ek__BackingField;

	public uint PlayerIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ActiveSessionGetRegisteredPlayerByIndexOptions()
	{
	}
}
