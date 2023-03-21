using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerDamageEvent : MonoBehaviour
{
	public UISprite m_Icon;

	public UISprite m_Background;

	public UISprite m_Backpiece;

	public UILabel m_DamageType;

	public UILabel m_DamageName;

	public float m_DisplayTime;

	public float m_FadeOutTime;

	public float m_TimeActive;

	public bool m_FadeOut;

	public bool m_TintIcon;

	public bool m_TintDamageType;

	public bool m_TintDamageName;

	public bool m_TintBG;

	public Color m_BGColorRed;

	public Color m_BGColorOrange;

	public Color m_BGColorGreen;

	public Color m_BGColorWhite;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAlpha(float amount)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public PlayerDamageEventProxy ToProxy()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void FromProxy(PlayerDamageEventProxy proxy)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "TintToBGColor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static void SpawnDamageEvent(string damageEventName, string damageEventType, string iconName, Color tint, bool fadeout, float displayTime, float fadeoutTime)
	{
	}

	[CallerCount(Count = 37)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 4)]
	public static void SpawnAfflictionEvent(string damageEventName, string damageEventType, string iconName, Color tint)
	{
	}

	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private static Color TintToBGColor(PlayerDamageEvent damageEvent, Color tint)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerDamageEvent()
	{
	}
}
