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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	[Calls(Type = typeof(NCUtils), Member = "GetItemRequirementsMatchCount")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Action_GetInvRequirementsCount()
	{
	}
}
