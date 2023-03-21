using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class iTweenPath : MonoBehaviour
{
	public string pathName;

	public Color pathColor;

	public List<Vector3> nodes;

	public int nodeCount;

	public static Dictionary<string, iTweenPath> paths;

	public bool initialized;

	public string initialName;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public iTweenPath()
	{
	}
}
