using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RemoveMissionMarkerFromMap : ActionTask
{
	public BBParameter<string> markerID;

	protected override string info
	{
		[Calls(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public Action_RemoveMissionMarkerFromMap()
	{
	}
}
