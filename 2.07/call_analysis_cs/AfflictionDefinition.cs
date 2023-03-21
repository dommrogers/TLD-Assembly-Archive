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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStandardDurationdUsed()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionDefinition), Member = "GetFirstAidItemUsed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetAlternateDurationUsed()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardMessageLocIdUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateMessageLocIdUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardAudioUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateAudioUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetStandardDurationdUsed")]
	[CalledBy(Type = typeof(AfflictionDefinition), Member = "GetAlternateDurationUsed")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(RemedyDefinition), Member = "GetFirstAidItem")]
	[CallsUnknownMethods(Count = 1)]
	private FirstAidItem GetFirstAidItemUsed(AfflictionRemedy remedy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionDefinition()
	{
	}
}
