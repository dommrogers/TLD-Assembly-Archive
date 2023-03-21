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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(TLD_Action), Member = "get_agent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 14)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_SetBaseAIFeeding()
	{
	}
}
