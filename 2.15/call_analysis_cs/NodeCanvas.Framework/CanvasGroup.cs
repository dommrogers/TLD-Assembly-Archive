using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public class CanvasGroup
{
	public string name;

	public Rect rect;

	public Color color;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CanvasGroup()
	{
	}

	[CallerCount(Count = 0)]
	public CanvasGroup(Rect rect, string name)
	{
	}
}
