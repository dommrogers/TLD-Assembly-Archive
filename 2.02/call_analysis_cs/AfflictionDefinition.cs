using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionDefinition : ScriptableObject
{
	public enum RemedyIndex
	{
		FirstRemedy,
		SecondRemedy
	}

	public AfflictionType m_AfflictionType;

	public AfflictionRemedies m_AlternateRemedies;

	public string m_DescriptionLocId;

	public string m_DisplayNameLocId;

	public float m_HPReduction;

	public string m_IconName;

	public AfflictionRemedies m_Remedies;

	public float m_RestHoursRequired;

	public string m_TreatmentDescriptionLocId;

	public string m_TreatmentLocId;

	public string m_NPCTreatmentLocId;

	public float m_WaterLitersRequired;

	public RemedyIndex m_StandardRemedyUsedForSFX;

	public RemedyIndex m_AlternateRemedyUsedForSFX;

	public string m_OnHealSFXOverride;

	public string m_OnHealLocIdOverride;

	public float m_OnHealDurationSecondsOverride;

	public TimelineRef m_HealedDiagnoseExitLeftTimelineOverride;

	public TimelineRef m_HealedDiagnoseExitRightTimelineOverride;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public string GetStandardMessageLocIdUsed()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetAlternateMessageLocIdUsed()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public string GetStandardAudioUsed()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public string GetAlternateAudioUsed()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float GetStandardDurationdUsed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public float GetAlternateDurationUsed()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateDurationUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardDurationdUsed")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardAudioUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateMessageLocIdUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardMessageLocIdUsed")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateAudioUsed")]
	private FirstAidItem GetFirstAidItemUsed(AfflictionRemedy remedy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public AfflictionDefinition()
	{
	}
}
