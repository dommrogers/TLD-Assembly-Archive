using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class ItemOwnership : ISettable
{
	private string _003CId_003Ek__BackingField;

	private OwnershipStatus _003COwnershipStatus_003Ek__BackingField;

	public string Id
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public OwnershipStatus OwnershipStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(OwnershipStatus);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(ItemOwnershipInternal), Member = "get_Id")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(ItemOwnershipInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ItemOwnershipInternal), Member = "get_Id")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ItemOwnership()
	{
	}
}
