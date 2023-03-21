using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SplineAutoAlign : MonoBehaviour
{
	public LayerMask raycastLayers;

	public float offset;

	public string[] ignoreTags;

	public Vector3 raycastDirection;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Spline), Member = "get_SplineNodes")]
	[Calls(Type = typeof(SplineNode), Member = "get_Position")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public void AutoAlign()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public SplineAutoAlign()
	{
	}
}
