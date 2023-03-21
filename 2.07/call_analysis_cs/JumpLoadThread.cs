using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class JumpLoadThread
{
	private JumpLoadCompleteDelegate m_OnComplete;

	private List<JumpData> m_JumpList;

	private Thread m_Thread;

	private bool m_Cancel;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public JumpLoadThread(JumpLoadCompleteDelegate onComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "GetState")]
	[Calls(Type = typeof(Thread), Member = "Abort")]
	[CallsUnknownMethods(Count = 3)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ExecuteSingleThreaded()
	{
	}
}
