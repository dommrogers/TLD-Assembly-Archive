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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Animator), Member = "CrossFade")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MecanimPlayAnimation()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
