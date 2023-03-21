using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Stroke
{
	private List<qb_Point> points;

	private qb_Point curPoint;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	public qb_Stroke()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	public qb_Point AddPoint(Vector3 position, Vector3 upVector, Vector3 dirVector)
	{
		return null;
	}

	[CallerCount(Count = 52)]
	[DeduplicatedMethod]
	public List<qb_Point> GetPoints()
	{
		return null;
	}

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public qb_Point GetCurPoint()
	{
		return null;
	}
}
