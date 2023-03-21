using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsCopyAttributeByIndexOptions
{
	private uint _003CAttrIndex_003Ek__BackingField;

	public uint AttrIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LobbyDetailsCopyAttributeByIndexOptions()
	{
	}
}
