using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckVectorDistance : ConditionTask
{
	public BBParameter<Vector3> vectorA;

	public BBParameter<Vector3> vectorB;

	public CompareMethod comparison;

	public BBParameter<float> distance;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckVectorDistance()
	{
	}
}
