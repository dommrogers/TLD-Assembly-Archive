using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CopyEntitlementByNameAndIndexOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private string _003CEntitlementName_003Ek__BackingField;

	private uint _003CIndex_003Ek__BackingField;

	public EpicAccountId LocalUserId
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

	public string EntitlementName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		set
		{
		}
	}

	public uint Index
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyEntitlementByNameAndIndexOptions()
	{
	}
}
