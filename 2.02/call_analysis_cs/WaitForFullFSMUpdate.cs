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
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CallsUnknownMethods(Count = 1)]
	public WaitForFullFSMUpdate()
	{
	}
}
