using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Gradient_DirectConverter : fsDirectConverter<Gradient>
{
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
	{
		return default(fsResult);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Gradient_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
