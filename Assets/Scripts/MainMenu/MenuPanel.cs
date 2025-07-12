// /*
// Created by Darsan
// */

using UnityEngine;

namespace MainMenu
{
	public class MenuPanel : MonoBehaviour
	{

		public void OnClickPlay() { UIManager.Instance.GameModePanel.Show(); }

		public void OnClickExit() { Application.Quit(); }


		public void RateGame() { Application.OpenURL("market://details?id="+Application.identifier); }
	}
}
