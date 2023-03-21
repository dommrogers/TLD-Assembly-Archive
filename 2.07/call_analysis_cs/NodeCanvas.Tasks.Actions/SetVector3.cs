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
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OperationTools), Member = "Operate")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetVector3()
	{
	}
}
