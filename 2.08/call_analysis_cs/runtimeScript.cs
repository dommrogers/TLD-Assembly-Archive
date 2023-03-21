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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ERRoadNetwork), Member = "DoBuildRoadNetwork")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERModularRoad), Member = "OOQCQOCQDD")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(ERRoadNetwork), Member = "CreateRoad")]
	[Calls(Type = typeof(ERRoadType), Member = ".ctor")]
	[Calls(Type = typeof(ERRoadNetwork), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERRoad), Member = "AddMarker")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ERRoad), Member = "GetLookatSmooth")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ERRoad), Member = "GetPosition")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERModularBase), Member = "OQOQDCCOOO")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public runtimeScript()
	{
	}
}
