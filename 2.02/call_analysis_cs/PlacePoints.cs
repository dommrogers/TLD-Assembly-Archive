using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlacePoints : MonoBehaviour
{
	public MinMax m_PrimaryFadeDistance;

	public MinMax m_SecondaryFadeDistance;

	public float m_FadeSpeed;

	public float m_MaxAlpha;

	public Renderer[] m_PlacePoints;

	public bool m_ShowIfFireIsBurning;

	public Fire m_AttachedFire;

	private float m_CurrentFade;

	private float m_DestinationFade;

	private float m_Distance;

	[Calls(Type = typeof(PlacePoints), Member = "UpdateColors")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlacePoints), Member = "ShouldShow")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	private void UpdateColors(Renderer placePoint, float fade)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	private bool ShouldShow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlacePoints()
	{
	}
}
