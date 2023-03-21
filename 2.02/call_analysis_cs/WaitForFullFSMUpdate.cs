using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Services;
using UnityEngine;

public class WaitForFullFSMUpdate : CustomYieldInstruction
{
	private int m_WaitForFrames;

	public override bool keepWaiting
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public WaitForFullFSMUpdate()
	{
	}
}
