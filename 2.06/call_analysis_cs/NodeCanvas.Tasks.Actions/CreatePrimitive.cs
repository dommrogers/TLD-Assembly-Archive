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

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CreatePrimitive()
	{
	}
}
