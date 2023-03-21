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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public MecanimSetLayerWeight()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
