using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Vector3OrTransformArray
{
	public static readonly string[] choices;

	public static readonly int vector3Selected;

	public static readonly int transformSelected;

	public static readonly int iTweenPathSelected;

	public int selected;

	public Vector3[] vectorArray;

	public Transform[] transformArray;

	public string pathName;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Vector3OrTransformArray()
	{
	}
}
