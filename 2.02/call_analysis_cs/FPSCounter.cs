using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
	public float m_updateInterval;

	private float m_Accum;

	private int m_Frames;

	private float m_Timeleft;

	private float m_FPS;

	private long m_AllocatedMemory;

	private long m_ReservedMemory;

	private long m_GraphicsMemory;

	private ulong m_TextureMemory;

	private float m_GPUTimeMs;

	private float m_CPUTimeMs;

	public event Action<FPSCounterEvent> FPSChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action<>), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static uint RetrieveFrameTimings(uint numFrames)
	{
		return 0u;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FPSCounter()
	{
	}
}
