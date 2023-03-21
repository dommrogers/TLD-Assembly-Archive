using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List<int> m_Pool;

	private int m_Current;

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	internal TargetPool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	internal int Get()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(TargetPool), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(TargetPool), Member = "Get")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 4)]
	private int Get(int i)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void Reset()
	{
	}
}
