using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class Rect_DirectConverter : fsDirectConverter<Rect>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 4)]
	protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public Rect_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
