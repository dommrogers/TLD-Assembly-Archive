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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(iTween), Member = "DrawPathHelper")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(iTweenEvent._003CStartEvent_003Ed__41), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	public iTweenPath()
	{
	}
}
