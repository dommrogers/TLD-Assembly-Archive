using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Story_MissionJumpItem : MonoBehaviour
{
	public UILabel m_Label_Mission;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Panel_Story_MissionJumpItem()
	{
	}
}
