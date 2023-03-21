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

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public float UpdateEntry(string name, string count, bool completed, float offsetY, float spacing)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void GetOrigPos()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ChallengeChecklistEntry()
	{
	}
}
