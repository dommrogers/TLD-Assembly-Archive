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

	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(ERRoadNetwork), Member = "DoBuildRoadNetwork")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERModularRoad), Member = "OOQQDOOODC")]
	[Calls(Type = typeof(ERRoad), Member = "Refresh")]
	[Calls(Type = typeof(ERMarkerExt), Member = "CreateInstance")]
	[Calls(Type = typeof(ERModularBase), Member = "OCCDCQCOQC")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(ERRoadType), Member = ".ctor")]
	[Calls(Type = typeof(ERRoadNetwork), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ERRoadNetwork), Member = "CreateRoad")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ERRoad), Member = "GetPosition")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ERModularBase), Member = "OOQQOOQODO")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public runtimeScript()
	{
	}
}
