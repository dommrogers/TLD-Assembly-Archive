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

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 8)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(TimeWidget), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	private void UpdateIconPositions(float angleDegrees)
	{
	}

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	private void UpdateIconFill(UISprite sprite, Vector3 pos, float angleDegrees)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetPositionOnCircle(float radius, float angleDegrees)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TimeWidget()
	{
	}
}
