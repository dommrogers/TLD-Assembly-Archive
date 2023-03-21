using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
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

	public AssetReferenceTimeline m_HealedDiagnoseExitLeftTimelineOverride;

	public AssetReferenceTimeline m_HealedDiagnoseExitRightTimelineOverride;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetStandardMessageLocIdUsed()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallerCount(Count = 0)]
	public string GetAlternateMessageLocIdUsed()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetStandardAudioUsed()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAlternateAudioUsed()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStandardDurationdUsed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetAlternateDurationUsed()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardMessageLocIdUsed")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardDurationdUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateAudioUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardAudioUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateMessageLocIdUsed")]
	[Calls(Type = typeof(RemedyDefinition), Member = "GetFirstAidItem")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateDurationUsed")]
	private FirstAidItem GetFirstAidItemUsed(AfflictionRemedy remedy)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public AfflictionDefinition()
	{
	}
}
