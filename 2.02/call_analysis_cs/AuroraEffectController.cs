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

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraEffectController), Member = "Enable")]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraEffectController), Member = "Start")]
	[CalledBy(Type = typeof(AuroraEffectController), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void Enable(bool on)
	{
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void MaybeRollActive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 2)]
	private bool PassesFilter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLifetime()
	{
	}

	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(AuroraEffectController), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
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
