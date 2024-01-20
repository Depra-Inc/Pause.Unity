// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Pause.Services
{
	internal readonly struct DebugPauseListener : IPauseListener
	{
		void IPauseListener.Pause() => Debug.Log(nameof(IPauseListener.Pause));

		void IPauseListener.Resume() => Debug.Log(nameof(IPauseListener.Resume));
	}
}