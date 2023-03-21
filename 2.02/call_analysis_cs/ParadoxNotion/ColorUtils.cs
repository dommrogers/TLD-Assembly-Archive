using System;
using System.Collections.Generic;
using System.Globalization;
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

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 6)]
	public static string ColorToHex(Color32 color)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	public static Color HexToColor(string hex)
	{
		return default(Color);
	}
}
