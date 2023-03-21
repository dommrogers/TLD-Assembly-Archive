using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class InstantiateGameObject : ActionTask<Transform>
{
	public BBParameter<Transform> parent;

	public BBParameter<Vector3> clonePosition;

	public BBParameter<Vector3> cloneRotation;

	public BBParameter<GameObject> saveCloneAs;

	protected override string info
	{
		[CallsUnknownMethods(Count = 34)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public InstantiateGameObject()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
