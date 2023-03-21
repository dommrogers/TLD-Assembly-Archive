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

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 37)]
	public float UpdateEntry(string name, string count, bool completed, float offsetY, float spacing)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void GetOrigPos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ChallengeChecklistEntry()
	{
	}
}
