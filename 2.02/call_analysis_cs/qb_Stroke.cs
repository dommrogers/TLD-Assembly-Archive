using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Stroke
{
	private List<qb_Point> points;

	private qb_Point curPoint;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public qb_Stroke()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public qb_Point AddPoint(Vector3 position, Vector3 upVector, Vector3 dirVector)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public List<qb_Point> GetPoints()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public qb_Point GetCurPoint()
	{
		return null;
	}
}
