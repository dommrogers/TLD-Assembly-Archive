using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEnvironmentPortal : MonoBehaviour
{
	public const int MAX_ENVIRONMENTS_PER_PORTAL = 2;

	public Vector3 axis;

	public AkEnvironment[] environments;

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public float GetAuxSendValueForPosition(Vector3 in_position, int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkEnvironmentPortal()
	{
	}
}
