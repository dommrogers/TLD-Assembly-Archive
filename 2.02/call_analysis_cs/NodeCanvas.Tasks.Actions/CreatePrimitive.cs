using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class CreatePrimitive : ActionTask
{
	public BBParameter<string> objectName;

	public BBParameter<Vector3> position;

	public BBParameter<Vector3> rotation;

	public BBParameter<PrimitiveType> type;

	public BBParameter<GameObject> saveAs;

	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CreatePrimitive()
	{
	}
}
