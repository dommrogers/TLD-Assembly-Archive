using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Bounds_DirectConverter : fsDirectConverter<Bounds>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "set_size")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Bounds_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
