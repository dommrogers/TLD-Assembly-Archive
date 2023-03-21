using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_EnableObjects : ActionTask
{
	public List<string> objectList;

	public List<BBParameter<string>> bbObjectList;

	public bool activeState;

	public bool scopeToState;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public Action_EnableObjects()
	{
	}
}
