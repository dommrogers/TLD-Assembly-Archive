using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Vector3OrTransform
{
	public static readonly string[] choices;

	public static readonly int vector3Selected;

	public static readonly int transformSelected;

	public int selected;

	public Vector3 vector;

	public Transform transform;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Vector3OrTransform()
	{
	}
}
