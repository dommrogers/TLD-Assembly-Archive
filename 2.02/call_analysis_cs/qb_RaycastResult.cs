using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_RaycastResult
{
	public bool success;

	public RaycastHit hit;

	[CallerCount(Count = 0)]
	public qb_RaycastResult(bool success, RaycastHit hit)
	{
	}
}
