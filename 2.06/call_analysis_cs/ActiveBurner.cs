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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public ActiveBurner()
	{
	}
}
