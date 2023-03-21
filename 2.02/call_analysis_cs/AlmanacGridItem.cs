using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AlmanacGridItem : MonoBehaviour
{
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
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionBlackboardVar")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherSetByName")]
	[Calls(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 44)]
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
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void ShowFalseBlizzard(int dayNumber)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AlmanacGridItem()
	{
	}
}
