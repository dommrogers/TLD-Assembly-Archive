using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PersistentControllerStateSaveData
{
	public struct StateSaveData
	{
		public int m_StateHash;

		public float m_Time;

		public string m_LayerName;
	}

	public struct ParameterSaveData
	{
		public int m_Hash;

		public string m_Value;

		public AnimatorControllerParameterType m_Type;
	}

	public List<StateSaveData> m_States;

	public List<ParameterSaveData> m_Parameters;

	public string m_Id;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PersistentControllerStateSaveData()
	{
	}
}
