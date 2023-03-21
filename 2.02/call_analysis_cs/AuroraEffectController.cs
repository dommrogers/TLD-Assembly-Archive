using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraEffectController : MonoBehaviour
{
	public float m_CheckForActivationIntervalHours;

	public float m_ChanceForActivation;

	public float m_MinDurationHours;

	public float m_MaxDurationHours;

	private bool m_Enabled;

	private bool m_RolledActive;

	private float m_ActiveElapsedHours;

	private float m_ElapsedHours;

	private float m_NextCheckActivationElapsedHours;

	private float m_DurationHours;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraEffectController), Member = "InstantiateEffects")]
	[Calls(Type = typeof(AuroraEffectController), Member = "Enable")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraEffectController), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(AuroraEffectController), Member = "Start")]
	[CalledBy(Type = typeof(AuroraEffectController), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void Enable(bool on)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeRollActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesFilter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLifetime()
	{
	}

	[CalledBy(Type = typeof(AuroraEffectController), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void InstantiateEffects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraEffectController()
	{
	}
}
