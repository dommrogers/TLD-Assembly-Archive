using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaceWindDirection : MonoBehaviour
{
	private Vector3 targetAngle;

	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FaceWindDirection()
	{
	}
}
