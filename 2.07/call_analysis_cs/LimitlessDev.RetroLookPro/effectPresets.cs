using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
public class effectPresets : ScriptableObject
{
	public List<ColorPalettePreset> presetsList;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public effectPresets()
	{
	}
}
