using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Gradient_DirectConverter : fsDirectConverter<Gradient>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "SerializeMember")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Gradient_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
