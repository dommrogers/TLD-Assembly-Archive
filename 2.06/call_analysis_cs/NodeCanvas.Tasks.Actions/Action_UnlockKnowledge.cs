using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockKnowledge : ActionTask
{
	public KnowledgeCateogry category;

	public string nameLocID;

	public string descLocID;

	public string notificationLocID;

	public bool showNotificationFlag;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_UnlockKnowledge()
	{
	}
}
