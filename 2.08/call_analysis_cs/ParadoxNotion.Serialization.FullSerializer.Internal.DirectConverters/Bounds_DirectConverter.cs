using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Bounds_DirectConverter : fsDirectConverter<Bounds>
{
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Bounds_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
