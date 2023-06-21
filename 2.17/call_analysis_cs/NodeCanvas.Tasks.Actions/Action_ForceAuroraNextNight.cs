using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ForceAuroraNextNight : ActionTask
{
	public BBParameter<bool> earlyWindowStartAllowed;

	public BBParameter<bool> lateWindowStartAllowed;

	public BBParameter<float> durationOverrideHoursMin;

	public BBParameter<float> durationOverrideHoursMax;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public Action_ForceAuroraNextNight()
	{
	}
}
