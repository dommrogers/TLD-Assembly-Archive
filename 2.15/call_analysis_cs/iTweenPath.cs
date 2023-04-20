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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public iTweenPath()
	{
	}
}
