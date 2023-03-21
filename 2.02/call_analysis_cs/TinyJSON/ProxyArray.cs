using System;
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public int Count
	{
		[CalledBy(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(JSON), Member = "DecodeMultiRankArray")]
		[CalledBy(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
		[CalledBy(Type = typeof(JSON), Member = "DecodeArray")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
	[CallsUnknownMethods(Count = 1)]
	public void Add(Variant item)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal bool CanBeMultiRankArray(int[] rankLengths)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[Calls(Type = typeof(ProxyArray), Member = "get_Count")]
	[Calls(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CalledBy(Type = typeof(ProxyArray), Member = "CanBeMultiRankArray")]
	[CallsUnknownMethods(Count = 6)]
	private bool CanBeMultiRankArray(int rank, int[] rankLengths)
	{
		return default(bool);
	}
}
