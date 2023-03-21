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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(AdjustMaterialByDistance), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private float DistanceToPlayer(Vector3 fxPos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AdjustMaterialByDistance), Member = "DistanceToPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public AdjustMaterialByDistance()
	{
	}
}
