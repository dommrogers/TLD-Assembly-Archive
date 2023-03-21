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
		[CallerCount(Count = 7)]
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
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GlobalParameters()
	{
	}
}
