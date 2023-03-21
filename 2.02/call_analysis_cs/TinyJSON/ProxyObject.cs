using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyObject : Variant, IEnumerable<KeyValuePair<string, Variant>>, IEnumerable
{
	internal const string TypeHintName = "@type";

	private Dictionary<string, Variant> dict;

	public string TypeHint
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public override Variant Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int Count
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
	[CallsUnknownMethods(Count = 8)]
	public ProxyObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator<KeyValuePair<string, Variant>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CTinyJSON_002EVariant_003E_003E_002EGetEnumerator()
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Add(string key, Variant item)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetValue(string key, out Variant item)
	{
		item = null;
		return default(bool);
	}
}
