using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace LimitlessDev.RetroLookPro;

[Serializable]
public class effectPreset
{
	public string effectName;

	public int numberOfColors;

	public Color32[] palette;

	public bool changed;

	public Color32[] pixels;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public effectPreset()
	{
	}
}
