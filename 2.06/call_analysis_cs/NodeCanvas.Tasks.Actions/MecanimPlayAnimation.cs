using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimPlayAnimation : ActionTask<Animator>
{
	public BBParameter<int> layerIndex;

	public BBParameter<string> stateName;

	public float transitTime;

	public bool waitUntilFinish;

	private AnimatorStateInfo stateInfo;

	private bool played;

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "CrossFade")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public MecanimPlayAnimation()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
