using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
{
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_normal")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onActive")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onFocused")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onHover")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onNormal")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_overflow")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(GUIStyle), Member = "get_name")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_focused")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GUIStyle), Member = "get_active")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_border")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_hover")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(GUIStyle), Member = "get_normal")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onActive")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onFocused")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onHover")]
	[Calls(Type = typeof(GUIStyle), Member = "get_onNormal")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_overflow")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsUnknownMethods(Count = 61)]
	[Calls(Type = typeof(GUIStyle), Member = "set_name")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 42)]
	[Calls(Type = typeof(GUIStyle), Member = "get_active")]
	[Calls(Type = typeof(GUIStyle), Member = "get_border")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_focused")]
	[Calls(Type = typeof(GUIStyle), Member = "get_margin")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(GUIStyle), Member = "get_name")]
	[Calls(Type = typeof(GUIStyle), Member = "get_hover")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GUIStyle_DirectConverter()
	{
		((fsDirectConverter<>)(object)this)._002Ector();
	}
}
