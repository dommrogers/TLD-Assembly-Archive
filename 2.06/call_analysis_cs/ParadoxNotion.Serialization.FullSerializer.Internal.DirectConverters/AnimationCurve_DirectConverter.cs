using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
{
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 10)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public AnimationCurve_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
