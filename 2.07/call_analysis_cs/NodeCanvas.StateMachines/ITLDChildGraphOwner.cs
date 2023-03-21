using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public interface ITLDChildGraphOwner
{
	GameObject childGraphPrefab
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		set;
	}
}
