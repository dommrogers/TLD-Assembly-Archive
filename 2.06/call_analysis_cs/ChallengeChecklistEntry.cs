using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ChallengeChecklistEntry : MonoBehaviour
{
	public UILabel m_NameLabel;

	public UILabel m_CountLabel;

	public GameObject m_ActiveSpriteObj;

	public GameObject m_CompletedSpriteObj;

	private Vector3 m_NameLabelOrigPos;

	private Vector3 m_NameLabelNoCountPos;

	private bool m_GotOrigPos;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallsUnknownMethods(Count = 19)]
	public float UpdateEntry(string name, string count, bool completed, float offsetY, float spacing)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void GetOrigPos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ChallengeChecklistEntry()
	{
	}
}
