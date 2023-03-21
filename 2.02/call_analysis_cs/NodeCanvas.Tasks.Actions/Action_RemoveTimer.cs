using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RemoveTimer : ActionTask
{
	public string id;

	public BBParameter<string> bbID;

	private string realId
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(Action_RemoveTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RemoveTimer), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_RemoveTimer), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Action_RemoveTimer), Member = "get_realId")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(Action_RemoveTimer), Member = "get_realId")]
	[Calls(Type = typeof(Action_RemoveTimer), Member = "get_realId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RemoveTimer()
	{
	}
}
