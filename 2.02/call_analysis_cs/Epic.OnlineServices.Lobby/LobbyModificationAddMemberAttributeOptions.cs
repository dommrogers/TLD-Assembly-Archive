using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyModificationAddMemberAttributeOptions
{
	private AttributeData _003CAttribute_003Ek__BackingField;

	private LobbyAttributeVisibility _003CVisibility_003Ek__BackingField;

	public AttributeData Attribute
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public LobbyAttributeVisibility Visibility
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LobbyAttributeVisibility);
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
	public LobbyModificationAddMemberAttributeOptions()
	{
	}
}
