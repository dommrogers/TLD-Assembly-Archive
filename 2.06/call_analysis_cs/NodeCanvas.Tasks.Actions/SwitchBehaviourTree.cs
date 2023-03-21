using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner>
{
	public BBParameter<BehaviourTree> behaviourTree;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SwitchBehaviourTree()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
