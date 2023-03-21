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

	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
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
	[Calls(Type = typeof(Thread), Member = "get_IsAlive")]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	private void ExecuteSingleThreaded()
	{
	}
}
