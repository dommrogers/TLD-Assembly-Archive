using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
public class ColorPalettePreset : ScriptableObject
{
	public effectPreset preset;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ColorPalettePreset()
	{
	}
}
