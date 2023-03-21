using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class MecanimIsInTransition : ConditionTask<Animator>
{
	public BBParameter<int> layerIndex;

	protected override string info
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MecanimIsInTransition()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
