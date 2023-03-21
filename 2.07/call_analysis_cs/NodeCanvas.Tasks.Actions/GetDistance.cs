using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetDistance : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> saveAs;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public GetDistance()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
