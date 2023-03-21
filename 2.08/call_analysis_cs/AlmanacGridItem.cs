using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class AlmanacGridItem : MonoBehaviour
{
	private PanelReference<Panel_Log> m_Log;

	public UISprite m_BlizzardSprite;

	public UISprite m_RedXSprite;

	public UISprite m_BorderSprite;

	public UISprite m_FillSprite;

	public UILabel m_DayLabel;

	public UILabel m_CatLabel;

	public UILabel m_ChanceLabel;

	public float m_ScaleCurrentDay;

	public float m_ScaleOtherDays;

	private Color m_BlizzardSpriteOrigColor;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionBlackboardVar")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public void SetUpGridItem(int dayNumber)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsNonBlizzardDay()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAlmanacPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void ShowFalseBlizzard(int dayNumber)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AlmanacGridItem()
	{
	}
}
