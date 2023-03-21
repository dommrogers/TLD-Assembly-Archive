using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CheckoutEntry : ISettable
{
	private string _003COfferId_003Ek__BackingField;

	public string OfferId
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckoutEntryInternal), Member = "get_OfferId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Set(CheckoutEntryInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckoutEntryInternal), Member = "get_OfferId")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CheckoutEntry()
	{
	}
}
