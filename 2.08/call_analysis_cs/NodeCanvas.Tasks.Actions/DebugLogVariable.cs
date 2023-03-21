using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class DebugLogVariable : ActionTask
{
	public BBParameter<object> log;

	public BBParameter<string> prefix;

	public float secondsToRun;

	public CompactStatus finishStatus;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public DebugLogVariable()
	{
	}
}
