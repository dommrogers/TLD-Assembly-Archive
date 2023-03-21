using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Story_MissionJumpItem : MonoBehaviour
{
	public UILabel m_Label_Mission;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Panel_Story_MissionJumpItem()
	{
	}
}
