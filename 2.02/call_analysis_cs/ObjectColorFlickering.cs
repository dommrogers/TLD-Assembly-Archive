using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectColorFlickering : MonoBehaviour
{
	public float duration;

	public Color color0;

	public Color color1;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "PingPong")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ObjectColorFlickering()
	{
	}
}
