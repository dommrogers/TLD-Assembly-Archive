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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 34)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public InstantiateGameObject()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
