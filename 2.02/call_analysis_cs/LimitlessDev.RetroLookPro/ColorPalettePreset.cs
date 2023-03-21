using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
public class ColorPalettePreset : ScriptableObject
{
	public effectPreset preset;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ColorPalettePreset()
	{
	}
}
