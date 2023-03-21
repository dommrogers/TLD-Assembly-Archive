using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConeShadowTestRotate : MonoBehaviour
{
	public float rotationSpeed;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ConeShadowTestRotate()
	{
	}
}
