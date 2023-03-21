using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class RectOffset_DirectConverter : fsDirectConverter<RectOffset>
{
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 13)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public RectOffset_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
