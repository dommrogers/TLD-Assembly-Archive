using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class GUIStyleUtils
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_margin")]
	[CallsUnknownMethods(Count = 6)]
	public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_padding")]
	[CallsUnknownMethods(Count = 6)]
	public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_border")]
	[CallsUnknownMethods(Count = 6)]
	public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "set_overflow")]
	[CallsUnknownMethods(Count = 6)]
	public static GUIStyle Overflow(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GUIStyle TextAlignment(this GUIStyle style, TextAnchor anchor)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GUIStyle RichText(this GUIStyle style, bool rich)
	{
		return null;
	}
}
