// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause.Utils
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(PauseServiceSceneProxy), DEFAULT_ORDER)]
	internal sealed class PauseServiceSceneProxy : MonoBehaviour, IPauseService
	{
		private IPauseService _service;

		private void Awake() => _service = new PauseService(
			GetComponent<IPauseInput>(),
			GetComponentsInChildren<IPauseListener>());

		bool IPauseService.IsPaused => _service.IsPaused;

		void IPauseService.Add(IPauseListener listener) => _service.Add(listener);

		void IPauseService.Remove(IPauseListener listener) => _service.Remove(listener);
	}
}