using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MatsAndGOs
{
	public List<MatAndTransformToMerged> mats;

	public List<GameObject> gos;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MatsAndGOs()
	{
	}
}
