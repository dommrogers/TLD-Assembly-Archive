using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetTrigger : ActionTask<Animator>
{
	public BBParameter<string> parameter;

	public BBParameter<int> parameterHashID;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public MecanimSetTrigger()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
