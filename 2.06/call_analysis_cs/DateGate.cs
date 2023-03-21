using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DateGate : MonoBehaviour
{
	public int m_StartYear;

	public int m_StartMonth;

	public int m_StartDay;

	public int m_StartHour;

	public int m_StartMinute;

	public int m_EndYear;

	public int m_EndMonth;

	public int m_EndDay;

	public int m_EndHour;

	public int m_EndMinute;

	public SpecialTODState m_AssociatedTODState;

	private GameObject m_GateObject;

	private int m_MinDay;

	private int m_MaxDay;

	private const int PDT_UTC_OFFSET = -7;

	private static TimeSpan m_PDTToUTC;

	private DateTime m_MinTime;

	private DateTime m_MaxTime;

	private bool m_Active;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks")]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks")]
	[Calls(Type = typeof(DateTime), Member = "op_Addition")]
	[Calls(Type = typeof(DateTime), Member = "op_Addition")]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	private bool PassesDateGate()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DateGate()
	{
	}
}
