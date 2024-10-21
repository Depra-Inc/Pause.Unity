// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using UnityEngine;

namespace Depra.Pause.Services
{
	[DisallowMultipleComponent]
	internal sealed class PauseReview : MonoBehaviour
	{
		private IPauseService _pause;

		private void Start() => _pause = new PauseService(
			GetComponent<IPauseInput>(),
			GetComponents<IPauseListener>());

		private void OnDestroy()
		{
			if (_pause is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}
}