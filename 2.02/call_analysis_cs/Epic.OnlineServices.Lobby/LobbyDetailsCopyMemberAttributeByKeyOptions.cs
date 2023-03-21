using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsCopyMemberAttributeByKeyOptions
{
	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private string _003CAttrKey_003Ek__BackingField;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public string AttrKey
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbyDetailsCopyMemberAttributeByKeyOptions()
	{
	}
}
