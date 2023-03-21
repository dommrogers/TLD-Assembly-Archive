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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CreatePrimitive()
	{
	}
}
