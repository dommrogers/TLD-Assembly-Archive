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

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	private void ExecuteSingleThreaded()
	{
	}
}
