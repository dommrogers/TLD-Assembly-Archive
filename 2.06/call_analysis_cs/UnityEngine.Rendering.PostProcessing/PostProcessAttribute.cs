using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessAttribute : Attribute
{
	public readonly Type renderer;

	public readonly PostProcessEvent eventType;

	public readonly string menuItem;

	public readonly bool allowInSceneView;

	internal readonly bool builtinEffect;

	[CallerCount(Count = 0)]
	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
	{
	}

	[CallerCount(Count = 0)]
	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
	{
	}
}
