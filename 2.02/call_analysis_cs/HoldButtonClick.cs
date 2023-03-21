using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HoldButtonClick : MonoBehaviour
{
	public float m_DelayValueStart;

	public float m_DelayValueMax;

	public int m_NumClicksUntilMax;

	private bool m_IsDown;

	private float m_Timer;

	private int m_ClickCounter;

	[CallerCount(Count = 0)]
	private void OnPress(bool isDown)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HoldButtonClick()
	{
	}
}
