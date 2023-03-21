using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetLayerWeight : ActionTask<Animator>
{
	public BBParameter<int> layerIndex;

	public BBParameter<float> layerWeight;

	public float transitTime;

	private float currentValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MecanimSetLayerWeight()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
