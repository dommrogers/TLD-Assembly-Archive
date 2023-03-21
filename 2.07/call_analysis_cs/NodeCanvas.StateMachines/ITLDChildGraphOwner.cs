using UnityEngine;

namespace NodeCanvas.StateMachines;

public interface ITLDChildGraphOwner
{
	GameObject childGraphPrefab { get; set; }
}
