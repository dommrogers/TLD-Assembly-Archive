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

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(ERRoadNetwork), Member = "DoBuildRoadNetwork")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERModularRoad), Member = "OOQCQOCQDD")]
	[Calls(Type = typeof(ERRoad), Member = "AddMarker")]
	[Calls(Type = typeof(ERRoadType), Member = ".ctor")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(ERRoadNetwork), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERRoadNetwork), Member = "CreateRoad")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ERRoad), Member = "GetLookatSmooth")]
	[Calls(Type = typeof(ERRoad), Member = "GetPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
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
