using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RevealMapLocation : ActionTask
{
	public BBParameter<string> markerID;

	public BBParameter<bool> revealLocationNameBB;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Action_RevealMapLocation()
	{
	}
}
