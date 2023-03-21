using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner>
{
	public BBParameter<BehaviourTree> behaviourTree;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SwitchBehaviourTree()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
