using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActiveBurner : MonoBehaviour
{
	public Fire m_Fire;

	public MinMax m_OpacityRange;

	public float m_WiggleEaseSpeed;

	public float m_WiggleIntervalSeconds;

	public bool m_AlwaysOn;

	private float m_CurrentTime;

	private float m_TargetOpacity;

	private float m_CurrentStrength;

	private float m_PreviousStrength;

	private Renderer m_Rend;

	private Material[] m_Materials;

	private Material m_Material;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ActiveBurner()
	{
	}
}
