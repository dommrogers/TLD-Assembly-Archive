using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectColorFlickering : MonoBehaviour
{
	public float duration;

	public Color color0;

	public Color color1;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PingPong")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ObjectColorFlickering()
	{
	}
}
