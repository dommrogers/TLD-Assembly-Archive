using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TimeWidget : MonoBehaviour
{
	public UISprite m_ArrowSprite;

	public UISprite m_MoonSprite;

	public UISprite m_SunSprite;

	private float m_SunRadius;

	private float m_MoonRadius;

	private bool m_Initialized;

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[Calls(Type = typeof(TimeWidget), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateIconPositions(float angleDegrees)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIconFill(UISprite sprite, Vector3 pos, float angleDegrees)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private Vector3 GetPositionOnCircle(float radius, float angleDegrees)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TimeWidget()
	{
	}
}
