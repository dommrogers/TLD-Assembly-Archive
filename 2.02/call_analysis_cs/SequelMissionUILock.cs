using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SequelMissionUILock : MonoBehaviour
{
	public ExperienceModeType m_LockIfChallengeIncomplete;

	public string m_SpriteNameOverride;

	public string m_LocIDOverride;

	private string m_SpriteNameOrig;

	private string m_LocIDOrig;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SequelMissionUILock), Member = "SetSpriteAndLabel")]
	[Calls(Type = typeof(SequelMissionUILock), Member = "SetSpriteAndLabel")]
	[Calls(Type = typeof(SequelMissionUILock), Member = "ShouldLock")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SequelMissionUILock), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 8)]
	private bool ShouldLock()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SequelMissionUILock), Member = "OnEnable")]
	[CalledBy(Type = typeof(SequelMissionUILock), Member = "OnEnable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void SetSpriteAndLabel(string spriteName, string locID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SequelMissionUILock()
	{
	}
}
