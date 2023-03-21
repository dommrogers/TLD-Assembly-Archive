using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SetVector3 : ActionTask
{
	public BBParameter<Vector3> valueA;

	public OperationMethod operation;

	public BBParameter<Vector3> valueB;

	public bool perSecond;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OperationTools), Member = "Operate")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetVector3()
	{
	}
}
