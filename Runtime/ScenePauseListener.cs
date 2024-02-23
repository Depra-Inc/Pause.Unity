// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Pause
{
	public abstract class ScenePauseListener : MonoBehaviour, IPauseListener
	{
		public abstract void Pause();

		public abstract void Resume();
	}
}