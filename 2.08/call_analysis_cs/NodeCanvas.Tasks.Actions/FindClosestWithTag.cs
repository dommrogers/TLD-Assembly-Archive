using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class FindClosestWithTag : ActionTask<Transform>
{
	public BBParameter<string> searchTag;

	public BBParameter<bool> ignoreChildren;

	public BBParameter<GameObject> saveObjectAs;

	public BBParameter<float> saveDistanceAs;

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public FindClosestWithTag()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
