using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class CreateGameObject : ActionTask
{
	public BBParameter<string> objectName;

	public BBParameter<Vector3> position;

	public BBParameter<Vector3> rotation;

	public BBParameter<GameObject> saveAs;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CreateGameObject()
	{
	}
}
