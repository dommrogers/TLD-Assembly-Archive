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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	public Action_RevealMapLocation()
	{
	}
}
