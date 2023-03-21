using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
	public float m_updateInterval;

	private PanelReference<Panel_HUD> m_HUD;

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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void UpdateGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static uint RetrieveFrameTimings(uint numFrames)
	{
		return default(uint);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FPSCounter()
	{
	}
}
