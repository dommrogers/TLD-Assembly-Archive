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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 18)]
	public JumpLoadThread(JumpLoadCompleteDelegate onComplete)
	{
	}

	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Thread), Member = "Abort")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Path), Member = "GetExtension")]
	[Calls(Type = typeof(Directory), Member = "GetFiles")]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumerationOptions), Member = "FromSearchOption")]
	private void ExecuteSingleThreaded()
	{
	}
}
