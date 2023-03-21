using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SimpleLightProbePlacer;

public class LightProbeGroupControl : MonoBehaviour
{
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LightProbeGroupControl()
	{
	}
}
