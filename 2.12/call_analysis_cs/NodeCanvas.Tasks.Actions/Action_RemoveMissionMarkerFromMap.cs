using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RemoveMissionMarkerFromMap : ActionTask
{
	public BBParameter<string> markerID;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public Action_RemoveMissionMarkerFromMap()
	{
	}
}
