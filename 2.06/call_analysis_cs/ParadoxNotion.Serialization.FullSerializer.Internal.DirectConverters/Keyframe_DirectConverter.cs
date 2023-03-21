using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 5)]
	protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Keyframe_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
