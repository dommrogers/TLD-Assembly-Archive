using System;
using Cpp2ILInjected.CallAnalysis;
using EasyRoads3Dv3;
using UnityEngine;

public class runtimeScript : MonoBehaviour
{
	public ERRoadNetwork roadNetwork;

	public ERRoad road;

	public GameObject go;

	public int currentElement;

	public float distance;

	public float speed;

	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ERModularRoad), Member = "OOQCQOCQDD")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERRoad), Member = "AddMarker")]
	[Calls(Type = typeof(ERRoadNetwork), Member = "DoBuildRoadNetwork")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(ERRoadType), Member = ".ctor")]
	[Calls(Type = typeof(ERRoadNetwork), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERRoadNetwork), Member = "CreateRoad")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ERRoad), Member = "GetPosition")]
	[Calls(Type = typeof(ERRoad), Member = "GetLookatSmooth")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERModularBase), Member = "OQOQDCCOOO")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public runtimeScript()
	{
	}
}
