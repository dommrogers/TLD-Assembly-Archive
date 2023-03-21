using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class ColorUtils
{
	private static Dictionary<Color32, string> colorHexCache;

	private static Dictionary<string, Color> hexColorCache;

	[CallerCount(Count = 0)]
	public static Color WithAlpha(this Color color, float alpha)
	{
		return default(Color);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 5)]
	public static string ColorToHex(Color32 color)
	{
		return null;
	}

	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static Color HexToColor(string hex)
	{
		return default(Color);
	}
}
