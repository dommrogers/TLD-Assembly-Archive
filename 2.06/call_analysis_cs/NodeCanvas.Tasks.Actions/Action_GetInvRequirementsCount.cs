using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_GetInvRequirementsCount : ActionTask
{
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	public string storeCountVar;

	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(NCUtils), Member = "GetItemRequirementsMatchCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public Action_GetInvRequirementsCount()
	{
	}
}
