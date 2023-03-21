using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerDamageEvent : MonoBehaviour
{
	private static Panel_HUD s_HUD;

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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 1)]
	public PlayerDamageEventProxy ToProxy()
	{
		return null;
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	public void FromProxy(PlayerDamageEventProxy proxy)
	{
	}

	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool HasHUD()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "TintToBGColor")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "HasHUD")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public static void SpawnDamageEvent(string damageEventName, string damageEventType, string iconName, Color tint, bool fadeout, float displayTime, float fadeoutTime)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "HasHUD")]
	public static void SpawnAfflictionEvent(string damageEventName, string damageEventType, string iconName, Color tint)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 1)]
	private static Color TintToBGColor(PlayerDamageEvent damageEvent, Color tint)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerDamageEvent()
	{
	}
}
