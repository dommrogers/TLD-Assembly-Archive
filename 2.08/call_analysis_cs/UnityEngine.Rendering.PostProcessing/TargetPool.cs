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

	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderInjectionPoint")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins")]
	[CalledBy(Type = typeof(TargetPool), Member = "Get")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
	[CalledBy(Type = typeof(TargetPool), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateSrcDstForOpaqueOnly")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
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
