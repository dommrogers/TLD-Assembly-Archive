using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectColorFlickering : MonoBehaviour
{
	public float duration;

	public Color color0;

	public Color color1;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PingPong")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 4)]
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
