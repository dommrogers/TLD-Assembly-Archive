using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyArray : Variant, IEnumerable<Variant>, IEnumerable
{
	private List<Variant> list;

	public override Variant Item
	{
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public int Count
	{
		[CalledBy(Type = typeof(JSON), Member = "DecodeArray")]
		[CalledBy(Type = typeof(JSON), Member = "DecodeMultiRankArray")]
		[CalledBy(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ProxyArray()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator<Variant> System_002ECollections_002EGeneric_002EIEnumerable_003CTinyJSON_002EVariant_003E_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Add(Variant item)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal bool CanBeMultiRankArray(int[] rankLengths)
	{
		return false;
	}

	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CalledBy(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[Calls(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool CanBeMultiRankArray(int rank, int[] rankLengths)
	{
		return false;
	}
}
