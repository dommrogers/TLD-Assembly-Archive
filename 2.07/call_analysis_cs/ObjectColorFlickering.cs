using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectColorFlickering : MonoBehaviour
{
	public float duration;

	public Color color0;

	public Color color1;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "PingPong")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ObjectColorFlickering()
	{
	}
}
