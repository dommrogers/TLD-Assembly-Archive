using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetBaseAIFeeding : TLD_Action
{
	public BBParameter<GameObject> target;

	public BBParameter<float> attackRadius;

	public BBParameter<float> holdGroundRadius;

	public float m_FeedingDurationHours;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetBaseAIFeeding()
	{
	}
}
