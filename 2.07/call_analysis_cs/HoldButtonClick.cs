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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	public HoldButtonClick()
	{
	}
}
