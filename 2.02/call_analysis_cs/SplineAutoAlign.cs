using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SplineAutoAlign : MonoBehaviour
{
	public LayerMask raycastLayers;

	public float offset;

	public string[] ignoreTags;

	public Vector3 raycastDirection;

	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineNode), Member = "get_Position")]
	[Calls(Type = typeof(Spline), Member = "get_SplineNodes")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	public void AutoAlign()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAutoAlign()
	{
	}
}
