using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
{
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GUIStyleState_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
