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
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(OperationTools), Member = "Operate")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SetVector3()
	{
	}
}
