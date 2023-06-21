using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FaceWindDirection : MonoBehaviour
{
	private Vector3 targetAngle;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FaceWindDirection()
	{
	}
}
