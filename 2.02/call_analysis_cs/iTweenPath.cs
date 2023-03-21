using System;
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
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[CallsUnknownMethods(Count = 5)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public iTweenPath()
	{
	}
}
