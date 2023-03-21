using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AdjustMaterialByDistance : MonoBehaviour
{
	private bool m_StaticPosition;

	private float m_NearDistance;

	private float m_FarDistance;

	private string m_ColorPropertyName;

	private Color m_NearColor;

	private Color m_FarColor;

	private Vector3 m_OriginalPosition;

	private float m_DistanceToPlayer;

	private float m_TransitionPercentage;

	private float m_NearDistanceSqr;

	private float m_FarDistanceSqr;

	private int m_ColorID;

	private Material m_ThisMaterial;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(AdjustMaterialByDistance), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private float DistanceToPlayer(Vector3 fxPos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AdjustMaterialByDistance), Member = "DistanceToPlayer")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AdjustMaterialByDistance()
	{
	}
}
