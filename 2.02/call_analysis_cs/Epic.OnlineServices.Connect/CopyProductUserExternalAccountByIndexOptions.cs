using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class CopyProductUserExternalAccountByIndexOptions
{
	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private uint _003CExternalAccountInfoIndex_003Ek__BackingField;

	public ProductUserId TargetUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public uint ExternalAccountInfoIndex
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 8)]
		get
		{
			return default(uint);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CopyProductUserExternalAccountByIndexOptions()
	{
	}
}
