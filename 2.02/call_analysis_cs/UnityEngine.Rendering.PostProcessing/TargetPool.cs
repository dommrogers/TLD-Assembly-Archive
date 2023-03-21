using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List<int> m_Pool;

	private int m_Current;

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallerCount(Count = 1)]
	internal TargetPool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	internal int Get()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TargetPool), Member = "Get")]
	[CalledBy(Type = typeof(TargetPool), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	private int Get(int i)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal void Reset()
	{
	}
}
