// SPDX-License-Identifier: Apache-2.0
// © 2023-2025 Depra <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Pause
{
	public abstract class ScenePauseListener : MonoBehaviour, IPauseListener
	{
		public abstract void OnPause();

		public abstract void OnResume();
	}
}