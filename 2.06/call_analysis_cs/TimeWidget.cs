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

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeWidget), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconPositions")]
	[Calls(Type = typeof(TimeWidget), Member = "UpdateIconFill")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateIconPositions(float angleDegrees)
	{
	}

	[CalledBy(Type = typeof(TimeWidget), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
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
