using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class MecanimIsInTransition : ConditionTask<Animator>
{
	public BBParameter<int> layerIndex;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public MecanimIsInTransition()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
