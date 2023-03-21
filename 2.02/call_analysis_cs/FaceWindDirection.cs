using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaceWindDirection : MonoBehaviour
{
	private Vector3 targetAngle;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FaceWindDirection()
	{
	}
}
