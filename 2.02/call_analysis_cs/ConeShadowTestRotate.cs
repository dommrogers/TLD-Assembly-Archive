using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConeShadowTestRotate : MonoBehaviour
{
	public float rotationSpeed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ConeShadowTestRotate()
	{
	}
}
