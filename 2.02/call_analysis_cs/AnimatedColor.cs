using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AnimatedColor()
	{
	}
}
