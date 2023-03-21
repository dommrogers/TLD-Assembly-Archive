using System.Collections.Generic;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ERRoadNetwork), Member = ".ctor")]
	[Calls(Type = typeof(ERRoadType), Member = ".ctor")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(ERRoadNetwork), Member = "CreateRoad")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ERModularBase), Member = "OCCDCQCOQC")]
	[Calls(Type = typeof(ERMarkerExt), Member = "CreateInstance")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERModularRoad), Member = "OOQQDOOODC")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(ERRoadNetwork), Member = "DoBuildRoadNetwork")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 44)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERRoad), Member = "GetPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERModularBase), Member = "OOQQOOQODO")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public runtimeScript()
	{
	}
}
