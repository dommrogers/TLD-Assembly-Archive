using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public interface ITLDChildGraphOwner
{
	GameObject childGraphPrefab
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}
}
