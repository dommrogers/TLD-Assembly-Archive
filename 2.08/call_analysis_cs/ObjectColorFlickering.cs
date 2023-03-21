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
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ObjectColorFlickering()
	{
	}
}
