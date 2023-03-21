using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GlobalParameters : MonoBehaviour
{
	[Serializable]
	public class DialogueSequenceParameters
	{
		public float m_LookatSensitivityMultiplier;

		public float m_StrafingSensitivityMultiplier;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public DialogueSequenceParameters()
		{
		}
	}

	public float m_FootStepPlayRange;

	public float m_FootPrintCreateRange;

	public float m_MaxPickupRange;

	public float m_PlayerRadiusIndoors;

	public float m_PlayerRadiusOutdoors;

	public float m_NearClipPlaneIndoors;

	public float m_NearClipPlaneOutdoors;

	public DialogueSequenceParameters m_DialogueSequenceParameters;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GlobalParameters()
	{
	}
}
