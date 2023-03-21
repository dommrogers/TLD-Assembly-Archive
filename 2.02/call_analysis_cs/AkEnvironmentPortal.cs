using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEnvironmentPortal : MonoBehaviour
{
	public const int MAX_ENVIRONMENTS_PER_PORTAL = 2;

	public Vector3 axis;

	public AkEnvironment[] environments;

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public float GetAuxSendValueForPosition(Vector3 in_position, int index)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkEnvironmentPortal()
	{
	}
}
