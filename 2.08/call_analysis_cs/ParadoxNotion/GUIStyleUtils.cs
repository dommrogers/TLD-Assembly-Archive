using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion;

public static class GUIStyleUtils
{
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RectOffset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
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
