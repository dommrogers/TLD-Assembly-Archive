using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class DecomposeVector : ActionTask
{
	public BBParameter<Vector3> targetVector;

	public BBParameter<float> x;

	public BBParameter<float> y;

	public BBParameter<float> z;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DecomposeVector()
	{
	}
}
