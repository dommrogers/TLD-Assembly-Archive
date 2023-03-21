using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SequelMissionUILock : MonoBehaviour
{
	public ExperienceModeType m_LockIfChallengeIncomplete;

	public string m_SpriteNameOverride;

	public string m_LocIDOverride;

	private string m_SpriteNameOrig;

	private string m_LocIDOrig;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SequelMissionUILock), Member = "ShouldLock")]
	[Calls(Type = typeof(SequelMissionUILock), Member = "SetSpriteAndLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(SequelMissionUILock), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private bool ShouldLock()
	{
		return false;
	}

	[CalledBy(Type = typeof(SequelMissionUILock), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetSpriteAndLabel(string spriteName, string locID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public SequelMissionUILock()
	{
	}
}
