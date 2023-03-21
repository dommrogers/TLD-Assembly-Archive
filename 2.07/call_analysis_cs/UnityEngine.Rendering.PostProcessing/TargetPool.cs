using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal class TargetPool
{
	private readonly List<int> m_Pool;

	private int m_Current;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	internal TargetPool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TargetPool), Member = "Get")]
	internal int Get()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TargetPool), Member = "Get")]
	[CalledBy(Type = typeof(TargetPool), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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
